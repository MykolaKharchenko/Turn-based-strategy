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

        public List<IUnit> UnitStacks; 

        public bool IsTurning = false;

        public PlayerSb()
        {
            archy = new Archers();
            wardy = new Swordmen();
            pussy = new Peasants();

            UnitStacks = new List<IUnit>()
            {
                archy,wardy,pussy
            };
        }   
    }
}
