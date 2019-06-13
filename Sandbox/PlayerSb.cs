using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandbox.Unit;

namespace Sandbox
{
    public class PlayerSb //: IEnumerable
    {
        public IUnit archy;
        public IUnit wardy;
        public IUnit pussy;
        public int queue;

        public void RevolveQueue()
        {
           // this.UnitStacks
            //UnitStacks.Sort
        }

        public List<IUnit> UnitStacks; 

        public bool IsTurning = false;

        public PlayerSb()
        {
            archy = new Archers();
            wardy = new Swordmen();
            pussy = new Peasants();

            UnitStacks = new List<IUnit>()
            {
                 new Archers(),new Swordmen(),new Peasants()
            };
        }

        public PlayerSb(string dataPath)
        {
            // must be written..
        }
    }
}
