using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using training.Services;

namespace training
{
    public class ApplicationViewModel  // ViewModel
    {
        IFileService fileService;
        IDialogService dialogService;

        ApplicationContext db;
        private Game game;
        //public ObservableCollection<Player> Players { get; set; }          - must I use ObservableCollection for Game/Player/Unit ????

        #region StartWindow button processing

        RelayCommand newGameCommand;
        public RelayCommand NewGameCommand
        {
            get
            {
                return newGameCommand ??
                    (newGameCommand = new RelayCommand((@new) =>
                    {
                        MainWindow mainWindow = new MainWindow(new Game());
                        if (mainWindow.ShowDialog() == true)
                        {
                            Game game = mainWindow.Game;
                            // bla-bla....
                        }
                    }
                    ));
            }
        }

        RelayCommand loadGameCommand;
        public RelayCommand LoadGameCommand
        {
            get
            {
                return loadGameCommand ??
                (loadGameCommand = new RelayCommand((selectedGamePath) =>
                {
                    if (selectedGamePath == null)
                        return;
                    string gamePath = selectedGamePath as string;
                    Game vm_game = fileService.Open(gamePath);

                    MainWindow mainWindow = new MainWindow(vm_game);
                    // must be added ....
                }
                ));
            }
        }

        RelayCommand exitAppCommand;
        public RelayCommand ExitAppCommand
        {
            get
            {
                return exitAppCommand ??
                    (exitAppCommand = new RelayCommand(mes =>
                    {
                        //  but in future this code's block will be rewrited
                        //  its here now only for reflection in UI
                        if (this.game == null)          
                        {
                            dialogService.ShowMessage("Game isn't saved, do you realy want to leave this battle???");

                        }
                    }
                    ));
            }
        }

        #endregion

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

        #region ctors VM
        public ApplicationViewModel()       // deafault constructor of VM
        {
        }

        public ApplicationViewModel(IDialogService dialogService, IFileService fileService)       // deafault constructor of VM
        {
            this.dialogService = dialogService;
            this.fileService = fileService;
        }
        #endregion  

        // implement INotifyPropertyChanged interface
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

