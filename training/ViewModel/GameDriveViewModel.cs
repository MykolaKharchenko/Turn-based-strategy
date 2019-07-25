using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using training.Interfaces;
using training.Models;
using training.Models.Units;
using training.Services;

namespace training.ViewModel
{
    public class GameDriveViewModel : INotifyPropertyChanged
    {
        IFileService fileService;
        IDialogService dialogService;

        #region notified props
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

        private IUnit selectedActiveUnit;
        public IUnit SelectedActiveUnit
        {
            get { return selectedActiveUnit; }
            set
            {
                selectedActiveUnit = value;
                OnPropertyChanged("SelectedActiveUnit");
            }
        }

        private IUnit selectedUnit;
        public IUnit SelectedUnit
        {
            get { return selectedUnit; }
            set
            {
                selectedUnit = value;
                OnPropertyChanged("SelectedUnit");
            }
        }

        #endregion

        #region ctor GameDriveVM
        public GameDriveViewModel(IDialogService _dialogService = null, IFileService _fileService = null, Game game = null)
        {
            dialogService = _dialogService;
            fileService = _fileService;

            if (game == null)
                currentGame = new Game();
            else
                currentGame = game; // StaticConfig.ConvertToObjectGame("");

            selectedActiveUnit = currentGame.GetCurrentActiveUnit();

            if (currentGame.IsGameOver == true)
                dialogService.ShowMessage("Game over");
        }
        #endregion

        #region commands   
        RelayCommand attackEnemyUnitCommand;
        public RelayCommand AttackEnemyUnitCommand
        {
            get
            {
                return attackEnemyUnitCommand ??
                (attackEnemyUnitCommand = new RelayCommand((obj) =>
                //   Execute block
                {
                    CheckEnemyCommand.Execute(this);   

                    IUnit AttackingUnit = obj as IUnit;
                    //AttackingUnit.GetDamage(selectedUnit as Unit);
                    currentGame.TurnSwitching();
                }
                //,                //   CanExecute condition  - т.е. комманда досупна к выполенению пока ЭТО условие == ТРУ
                //(obj) => CurrentGame.IsGameOver == false)       //  && obj != null
                ));
            }
        }

        RelayCommand checkCommand;
        public RelayCommand CheckCommand
        {
            get
            {
                return checkCommand ??
                    (checkCommand = new RelayCommand(obj =>
                    {
                        //Phone phone = new Phone();
                        //Phones.Insert(0, phone);
                        //SelectedPhone = phone;
                    }));
            }

        }

        RelayCommand checkEnemyCommand;
        public RelayCommand CheckEnemyCommand
        {            
            get
            {
                return checkEnemyCommand ??
                (checkEnemyCommand = new RelayCommand((obj) =>
                //   Execute block
                {

                }));
            }
        }

        RelayCommand specSkillUnitCommand;
        public RelayCommand SpecSkillUnitCommand
        {
            get
            {
                return specSkillUnitCommand ??
                (specSkillUnitCommand = new RelayCommand((obj) =>
                {                                      //   Execute block

                }//,
                //(obj) => (CurrentGame.IsGameOver == true && SelectedActiveUnit.AbilitySpecialSkill())   //   CanExecute condition  - т.е. комманда досупна к выполенению пока ЭТО условие == ТРУ
                ));
            }
        }

        RelayCommand moveUnitCommand;
        public RelayCommand MoveUnitCommand
        {
            get
            {
                return moveUnitCommand ??
                (moveUnitCommand = new RelayCommand((obj) =>
                {
                },
                (obj) => (CurrentGame.IsGameOver == true)   //   CanExecute condition  - т.е. комманда досупна к выполенению пока ЭТО условие == ТРУ
                ));
            }
        }
        #endregion

        #region implementation INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string prop = "")      // CallerMemberName - read!!!
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
    }
}