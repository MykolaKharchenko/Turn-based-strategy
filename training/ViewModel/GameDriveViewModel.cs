using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using training.Models;
using training.Services;

namespace training.ViewModel
{
    public class GameDriveViewModel : INotifyPropertyChanged
    {
        IFileService fileService;
        IDialogService dialogService;

        private Game currentGame;
        public Game CurrentGame
        {
            get { return currentGame; }
            set
            {
                currentGame = value;
                OnPropertyChanged("CurrentGame");
            }
        }

        private Player selectedPlayer;
        public Player SelectedPlayer
        {
            get { return selectedPlayer; }
            set
            {
                selectedPlayer = value;
                OnPropertyChanged("SelectedPlayer");
            }
        }

        public GameDriveViewModel( IDialogService _dialogService = null,  IFileService _fileService = null, Game game = null)
        {
            dialogService = _dialogService;
            fileService = _fileService;

            currentGame = new Game();

            //if (game.IsGameOver == true)
            //    dialogService.ShowMessage("Game over");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string prop = "")      // CallerMemberName - read!!!
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}