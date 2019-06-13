using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training.Models
{
    public class Game
    {
        private int gameId;
        public string pathGameAddress;

        public Player PlayerLeft;
        public Player PlayerRight;
        Battlefield bf = new Battlefield();
        public int turnCounter = 0;

        public Game()
        {
            PlayerLeft = new Player();
            PlayerRight = new Player();
            StartGame();
        }

        public Game(string gamePath)          // for saved game
        {
            // .. must be written
        }

        public void StartGame()
        {
            {
                if (PlayerLeft.archers.UnitSize > PlayerRight.archers.UnitSize)
                {
                    PlayerLeft.IsTurning = true;
                    return;
                }

                if (PlayerLeft.swordsmen.UnitSize > PlayerRight.swordsmen.UnitSize)
                {
                    PlayerLeft.IsTurning = true;
                    return;
                }

                if (PlayerLeft.peasants.UnitSize > PlayerRight.peasants.UnitSize)
                {
                    PlayerLeft.IsTurning = true;
                    return;
                }

                if (GetTotalPlayerUnitSize(PlayerLeft) > GetTotalPlayerUnitSize(PlayerRight))
                {
                    PlayerLeft.IsTurning = true;
                    return;
                }

                PlayerRight.IsTurning = true;
            }
        }

        //public void Turn(Unit.Unit targetUnitStack = null, Battlefield bf = null)
        //{
        //    //p1.archy.GetDamage();
        //}

        public int GetTotalPlayerUnitSize(Player player)
        {
            return 0; // player.archy.UnitSize + player.wardy.UnitSize + player.pussy.UnitSize;
        }
    }
}
