using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using training.Models;
using training.Services;

namespace training.ViewModel
{
    public class GameMenuViewModel : INotifyPropertyChanged
    {
        IFileService fileService;
        IDialogService dialogService;

        ApplicationContext db;
        IEnumerable<Game> games;
        public IEnumerable<Game> Games
        {
            get { return games; }
            set
            {
                games = value;
                OnPropertyChanged("Games");
            }
        }

        //must I use ObservableCollection for Game/Player/Unit ????

        #region StartWindow button processing via commands

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
                        if (this.games == null)
                        {
                            dialogService.ShowMessage("Game isn't saved, do you realy want to leave this battle???");

                        }
                    }
                    ));
            }
        }

        #endregion

        #region ctors VM
        public GameMenuViewModel(IDialogService _dialogService, IFileService _fileService)       // default constructor of VM
        {
            dialogService = _dialogService;
            fileService = _fileService;

            db = new ApplicationContext();
            //db.Games.Load();
            //Games = db.Games.Local.ToBindingList();
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string prop = "")      // CallerMemberName - read!!!
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
