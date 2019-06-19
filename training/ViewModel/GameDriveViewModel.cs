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

        ApplicationContext db;
        private Game game;

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

        public GameDriveViewModel(IDialogService dialogService = null, IFileService fileService = null)
        {
            game = new Game();
        }

        public GameDriveViewModel(string gamePath, IDialogService dialogService = null, IFileService fileService = null)
        {
            //game = deserialize from db
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string prop = "")      // CallerMemberName - read!!!
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}