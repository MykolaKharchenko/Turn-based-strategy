using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public ObservableCollection<Game> Games;
        private Game selectedGame;
        public Game SelectedGame
        {
            get { return selectedGame; }
            set
            {
                selectedGame = value;
                OnPropertyChanged("SelectedGame");
            }
        }

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
                (loadGameCommand = new RelayCommand((obj) =>
                {
                    try
                    {
                        if (dialogService.OpenFileDialog() == true)
                        {
                            var game = fileService.Open(dialogService.FilePath);
                            dialogService.ShowMessage("Файл открыт");
                        }
                    }
                    catch (Exception ex)
                    {
                        dialogService.ShowMessage(ex.Message);
                    }

                    //string gamePath = obj as string;
                    //Game vm_game = fileService.Open(gamePath);
                    //MainWindow mainWindow = new MainWindow(vm_game);
                    
                    // must be added ....
                }));
            }
        }
        // команда открытия файла
        //private RelayCommand openCommand;
        //public RelayCommand OpenCommand
        //{
        //    get
        //    {
        //        return openCommand ??
        //          (openCommand = new RelayCommand(obj =>
        //          {
        //              try
        //              {
        //                  if (dialogService.OpenFileDialog() == true)
        //                  {
        //                      var phones = fileService.Open(dialogService.FilePath);
        //                      Games.Clear();
        //                      foreach (var p in Games)
        //                          Games.Add(p);
        //                      dialogService.ShowMessage("Файл открыт");
        //                  }
        //              }
        //              catch (Exception ex)
        //              {
        //                  dialogService.ShowMessage(ex.Message);
        //              }
        //          }));
        //    }
        //}

        RelayCommand saveGameCommand;
        public RelayCommand SaveGameCommand
        {
            get
            {
                return saveGameCommand ??
                  (saveGameCommand = new RelayCommand(obj =>
                  {
                      try
                      {
                          SelectedGame = new Game();

                          if (dialogService.SaveFileDialog() == true)
                          {
                              fileService.Save(dialogService.FilePath, SelectedGame);
                              dialogService.ShowMessage("Файл сохранен");
                          }
                      }
                      catch (Exception ex)
                      {
                          dialogService.ShowMessage(ex.Message);
                      }
                  }));
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
                        if(true)//(SelectedGame != null)
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
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string prop = "")      // CallerMemberName - read!!!
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
