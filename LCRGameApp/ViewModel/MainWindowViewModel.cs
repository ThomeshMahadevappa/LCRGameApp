using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using LCRGameApp.Annotations;
using LCRGameApp.Command;
using LCRGameApp.Model;

namespace LCRGameApp.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged, IDataErrorInfo
    {
        #region Properties

        public ICommand SimulateCommand { get; set; }

        private string _numberOfPlayers;

        public string NumberOfPlayers
        {
            get => _numberOfPlayers;
            set
            {
                _numberOfPlayers = value;
                NotifyPropertyChanged(nameof(NumberOfPlayers));
            }
        }

        private string _numberOfGames;

        public string NumberOfGames
        {
            get => _numberOfGames;
            set
            {
                _numberOfGames = value;
                NotifyPropertyChanged(nameof(NumberOfGames));
            }
        }

        private string _numberOfTurns;

        public string NumberOfTurns
        {
            get => _numberOfTurns;
            set
            {
                _numberOfTurns = value;
                NotifyPropertyChanged(nameof(NumberOfTurns));
            }
        }

        private string _shortestGame;

        public string ShortestGame
        {
            get => _shortestGame;
            set
            {
                _shortestGame = value;
                NotifyPropertyChanged(nameof(ShortestGame));
            }
        }

        private string _longestGame;

        public string LongestGame
        {
            get => _longestGame;
            set
            {
                _longestGame = value;
                NotifyPropertyChanged(nameof(LongestGame));
            }
        }

        private string _averageGame;

        public string AverageGame
        {
            get => _averageGame;
            set
            {
                _averageGame = value;
                NotifyPropertyChanged(nameof(AverageGame));
            }
        }

        #endregion

        #region Contructor
        public MainWindowViewModel()
        {
            //Default settings
            NumberOfPlayers = "3";
            NumberOfGames = "100";
            SimulateCommand = new RelayCommand(OnSimulateCommand, CanExecuteCommand);
        }

        #endregion

        #region Private Methods

        private bool CanExecuteCommand(object obj)
        {
            if (int.TryParse(NumberOfPlayers, out var numberOfPlayersResult))
            {
                if (numberOfPlayersResult is < 3 or > 7)
                {
                    return false;
                }
            }
            if (!int.TryParse(NumberOfGames, out var numberOfGamesResult)) return true;
            return numberOfGamesResult is >= 100 and <= 100000;
        }

        private void OnSimulateCommand(object obj)
        {
            var numberOfPlayers = int.Parse(NumberOfPlayers);
            var numberOfGames = int.Parse(NumberOfGames);
            var game = new Game(numberOfGames, numberOfPlayers, 3);
            NumberOfTurns = game.NumberOfLengths.Count.ToString();
            if (game.NumberOfLengths.Count <= 0) return;
            ShortestGame = game.NumberOfLengths.First().ToString();
            LongestGame = game.NumberOfLengths.Last().ToString();
            AverageGame = (game.NumberOfLengths.First() + game.NumberOfLengths.Last() / 2).ToString();
        }

        #endregion

        #region NotifyProperChanged
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public string Error { get; }

        public string this[string columnName]
        {
            get
            {
                if (columnName.Equals(nameof(NumberOfPlayers)))
                {
                    if (int.TryParse(NumberOfPlayers, out var result))
                    {
                        if (result is < 3 or > 7)
                        {
                            return "Valid is out of range. Range should be 3-7";
                        }
                    }
                }

                if (!columnName.Equals(nameof(NumberOfGames))) return string.Empty;
                {
                    if (!int.TryParse(NumberOfGames, out var result)) return string.Empty;
                    if (result is < 100 or > 100000)
                    {
                        return "Valid is out of range. Range should be 100-100000";
                    }
                }
                return string.Empty;
            }
        }
    }
}
