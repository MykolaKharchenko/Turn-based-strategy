using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training.Models
{
    public class Game : INotifyPropertyChanged
    {
        [System.ComponentModel.DataAnnotations.Key]
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
                if (playerLeft.archers.UnitSize > playerRight.archers.UnitSize)
                {
                    playerLeft.IsTurning = true;
                    return;
                }

                if (playerLeft.swordsmen.UnitSize > playerRight.swordsmen.UnitSize)
                {
                    playerLeft.IsTurning = true;
                    return;
                }

                if (playerLeft.peasants.UnitSize > playerRight.peasants.UnitSize)
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

        public int GetTotalPlayerUnitSize(Player player)
        {
            return player.archers.UnitSize + player.swordsmen.UnitSize + player.peasants.UnitSize;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string prop = "")      // CallerMemberName - read!!!
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
