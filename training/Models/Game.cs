using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace training.Models
{
    [DataContract]
    public class Game : INotifyPropertyChanged
    {
        [Key]
        public int GameId { get; set; }

        private string pathGameAddress;
        public string PathGameAddress
        {
            get { return pathGameAddress; }
            set
            {
                pathGameAddress = value;
                OnPropertyChanged("PathGameAddress");
            }
        }

        private Player playerLeft;
        public Player PlayerLeft
        {
            get { return playerLeft; }
            set
            {
                playerLeft = value;
                OnPropertyChanged("PlayerLeft");
            }
        }

        private Player playerRight;
        public Player PlayerRight
        {
            get { return playerRight; }
            set
            {
                playerRight = value;
                OnPropertyChanged("PlayerRight");
            }
        }

        private Battlefield battlefield = new Battlefield();
        public Battlefield Battlefield
        {
            get { return battlefield; }
            set
            {
                battlefield = value;
                OnPropertyChanged("Battlefield");
            }
        }

        private int turnCounter;
        public int TurnCounter
        {
            get { return turnCounter; }
            set
            {
                turnCounter = value;
                OnPropertyChanged("TurnCounter");
            }
        }

        #region ctors Game
        public Game()
        {
            playerLeft = new Player();
            playerRight = new Player();

            //var s = playerLeft.Archers.passiveUnitImagePath;
            //var f = playerLeft.Archers.UnitSize;

            StartGame();
        }             // for new game

        public Game(string gamePath) // for saved game
        {
            // .. must be written
        }
        #endregion

        public void StartGame()
        {
            {
                if (playerLeft.Archers.UnitSize > playerRight.Archers.UnitSize)
                {
                    playerLeft.IsTurning = true;
                    return;
                }

                if (playerLeft.Swordmen.UnitSize > playerRight.Swordmen.UnitSize)
                {
                    playerLeft.IsTurning = true;
                    return;
                }

                if (playerLeft.Peasants.UnitSize > playerRight.Peasants.UnitSize)
                {
                    playerLeft.IsTurning = true;
                    return;
                }

                if (GetTotalPlayerUnitSize(playerLeft) > GetTotalPlayerUnitSize(playerRight))
                {
                    playerLeft.IsTurning = true;
                    return;
                }
                playerRight.IsTurning = true;
            }
        }

        public void Turn(Interfaces.IUnit targetUnitStack = null, Battlefield bf = null)
        {
        }

        public bool IsGameOver
        {
            get { return ((GetTotalPlayerUnitSize(PlayerLeft) > 0) || (GetTotalPlayerUnitSize(PlayerRight) > 0)) ? false : true; }            
        }

        public int GetTotalPlayerUnitSize(Player player)
        {
            return player.Archers.UnitSize + player.Swordmen.UnitSize + player.Peasants.UnitSize;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string prop = "")      // CallerMemberName - read!!!
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
