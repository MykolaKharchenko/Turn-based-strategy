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
        }

        public GameSb(string gamePath)
        {
            // .. must be written
        }

        public void StartGame()
        {
            if (p1.Archers.stackSize != p2.Archers.stackSize)
            {
                if (p1.Archers.stackSize > p2.Archers.stackSize)
                    p1.IsTurning = true;
                else
                    p2.IsTurning = true;
            }
            else
            {
                if (p1.Swordmen.stackSize != p2.Swordmen.stackSize)
                {
                    if (p1.Swordmen.stackSize > p2.Swordmen.stackSize)
                        p1.IsTurning = true;
                    else
                        p2.IsTurning = true;
                }
                else
                {
                    if (p1.Peasants.stackSize != p2.Peasants.stackSize)
                    {
                        if (p1.Peasants.stackSize > p2.Peasants.stackSize)
                            p1.IsTurning = true;
                        else
                            p2.IsTurning = true;
                    }
                    else
                    {
                        if (p1.Peasants.stackSize+ p1.Swordmen.stackSize+ p1.Archers.stackSize > p2.Peasants.stackSize + p2.Swordmen.stackSize + p2.Archers.stackSize)
                            p1.IsTurning = true;
                        else
                            p2.IsTurning = true;
                    }
                }
            }
        }

        public void Step(Unit.UnitStack targetUnitStack = null, Battlefield bf = null)
        {            
            p1.Archers.GetDamage(p2.Peasants);
            //IAction x = new 
        }
    }
}
