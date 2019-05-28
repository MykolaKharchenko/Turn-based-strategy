using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training.Services
{
    public class GameDrive
    {
        //private Player palyerLeft;
        //private Player palyerRight;
        //private int gameId;
        //private string pathAddress;

        public static Random rnd = new Random();
        
        public static int GetRandomStackSize()
        {
            return rnd.Next(5, 20);
        }

        public void InitUnit(string gamePath)
        {
            if (gamePath.Trim() != "")
                // continued game
            {

            }
            else
            // new game
            {

            }
        }
    }
}
