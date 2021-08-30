using System.Collections.Generic;
using System.Linq;

namespace LCRGameApp.Model
{
    public sealed class Game
    {
        private int NumberOfGames { get; }
        private int NumberOfPlayers { get; }
        private int NumberOfChips { get; }
        private readonly IList<Player> _noOfPlayers = new List<Player>();
        public List<int> NumberOfLengths { get; private set; } = new List<int>();

        public Game(int numberOfGames, int numberOfPlayers, int numberOfChips)
        {
            NumberOfGames = numberOfGames;
            NumberOfPlayers = numberOfPlayers;
            NumberOfChips = numberOfChips;
            StartGame();
        }

        private void StartGame()
        {
            for (var numberOfGamesIndex = 0; numberOfGamesIndex < NumberOfGames; numberOfGamesIndex++)
            {
                _noOfPlayers.Clear();
                for (var players = 0; players < NumberOfPlayers; players++)
                {
                    _noOfPlayers.Add(new Player(players + 1, NumberOfChips));
                }

                var numberOfLength = 0;
                var canBreak = false;
                while (true)
                {
                    for (var playerIndex = 0; playerIndex < _noOfPlayers.Count; playerIndex++)
                    {
                        var numberOfPlayersLeft = _noOfPlayers.Where(player => player.NoOfChipsAvailable == 0);
                        if (numberOfPlayersLeft.Count() == _noOfPlayers.Count - 1)
                        {
                            canBreak = true;
                            break;
                        }

                        var leftIndex = playerIndex - 1;
                        var rightIndex = playerIndex + 1;
                        if (playerIndex == 0)
                        {
                            leftIndex = _noOfPlayers.Count - 1;
                        }

                        if (playerIndex == _noOfPlayers.Count - 1)
                        {
                            rightIndex = 0;
                        }

                        var numberOfDices = 3;
                        if (_noOfPlayers[playerIndex].NoOfChipsAvailable < 3)
                        {
                            numberOfDices = _noOfPlayers[playerIndex].NoOfChipsAvailable;
                        }
                        var diceResults = _noOfPlayers[playerIndex].RollDices(numberOfDices);
                        numberOfLength += 1;
                        foreach (var diceResult in diceResults)
                        {
                            switch (diceResult)
                            {
                                case DiceResult.Right:
                                    _noOfPlayers[rightIndex].AddDice();
                                    _noOfPlayers[playerIndex].RemoveDice();
                                    break;
                                case DiceResult.Left:
                                    _noOfPlayers[leftIndex].AddDice();
                                    _noOfPlayers[playerIndex].RemoveDice();
                                    break;
                                case DiceResult.Center:
                                    _noOfPlayers[playerIndex].RemoveDice();
                                    break;
                            }
                        }
                    }

                    if (canBreak)
                    {
                        break;
                    }
                }

                NumberOfLengths.Add(numberOfLength);
                NumberOfLengths.Sort();
            }
        }
    }
}
