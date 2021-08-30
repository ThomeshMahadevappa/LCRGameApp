using System;
using System.Collections.Generic;

namespace LCRGameApp.Model
{
    public class Player:IDice
    {
        public int PlayerNumber { get; }
        private readonly IList<Chips> _chipsList = new List<Chips>();
        public int NoOfChipsAvailable => _chipsList.Count;

        public Player(int playerNumber, int numberOfChips)
        {
            PlayerNumber = playerNumber;

            for (var counter = 0; counter < numberOfChips; counter++)
            {
                _chipsList.Add(new Chips(counter + 1));
            }
        }

        public IList<DiceResult> RollDices(int numberOfDices)
        {
            IList<DiceResult> diceResults = new List<DiceResult>();
            for (var diceIndex = 0; diceIndex < numberOfDices; diceIndex++)
            {
                diceResults.Add(RollDice());
            }

            return diceResults;
        }

        public void AddDice()
        {
            _chipsList.Add(new Chips(_chipsList.Count + 1));
        }

        public void RemoveDice()
        {
            _chipsList.RemoveAt(0);
        }

        public DiceResult RollDice()
        {
            var random = new Random();
            return (DiceResult)random.Next(1, 7);
        }
    }
}
