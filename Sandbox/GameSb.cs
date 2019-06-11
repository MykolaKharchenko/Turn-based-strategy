using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class GameSb
    {
        public PlayerSb p1 = new PlayerSb();
        public PlayerSb p2 = new PlayerSb();
        Battlefield bf = new Battlefield();
        public int turnCounter = 0;

        public GameSb()
        {
            p1 = new PlayerSb();
            p2 = new PlayerSb();
            StartGame();
        }

        public GameSb(string gamePath)          // for saved game
        {
            // .. must be written
        }

        public void StartGame()
        {
            //if (p1.archy.UnitSize!= p2.archy.GetUnitSize())
            //{
            //    if (p1.archy.GetUnitSize() > p2.archy.GetUnitSize())
            //        p1.IsTurning = true;
            //    else
            //        p2.IsTurning = true;    
            //}
            //else
            //{
            //    if (p1.wardy.GetUnitSize()!= p2.wardy.GetUnitSize())
            //    {
            //        if (p1.wardy.GetUnitSize() > p2.wardy.GetUnitSize())
            //            p1.IsTurning = true;
            //        else
            //            p2.IsTurning = true;
            //    }
            //    else
            //    {
            //        if (p1.pussy.GetUnitSize() != p2.pussy.GetUnitSize())
            //        {
            //            if (p1.pussy.GetUnitSize() > p2.pussy.GetUnitSize())
            //                p1.IsTurning = true;
            //            else
            //                p2.IsTurning = true;
            //        }
            //        else
            //        {
            //            if (p1.archy.GetUnitSize() + p1.wardy.GetUnitSize() + p1.pussy.GetUnitSize() > p2.archy.GetUnitSize() + p2.wardy.GetUnitSize() + p2.pussy.GetUnitSize())
            //                p1.IsTurning = true;
            //            else
            //                p2.IsTurning = true;
            //        }
            //    }
            //}

            {
                if (p1.archy.UnitSize > p2.archy.UnitSize)
                     p1.IsTurning = true;

                if (p1.wardy.UnitSize > p2.wardy.UnitSize)
                    p1.IsTurning = true;

                if (p1.pussy.UnitSize > p2.pussy.UnitSize)
                    p1.IsTurning = true;

                if (GetTotalPlayerUnitSize(p1)> GetTotalPlayerUnitSize(p2))
                    p1.IsTurning = true;

                p2.IsTurning = true; 
            }


        }

        public void Step(Unit.Unit targetUnitStack = null, Battlefield bf = null)
        {            
            p1.archy.GetDamage();
        }


        public int GetTotalPlayerUnitSize(PlayerSb player)
        {
            return player.archy.UnitSize + player.wardy.UnitSize + player.pussy.UnitSize;
        }
    }
}
