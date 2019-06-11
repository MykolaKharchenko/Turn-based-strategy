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
        public UnitStack Archers;
        public UnitStack Peasants;
        public UnitStack Swordmen;
        public bool IsTurning = false;

        public PlayerSb()
        {
            this.Archers = new Archers();
            this.Swordmen = new Swordmen();
            this.Peasants = new Peasants();
        }
    }
}
