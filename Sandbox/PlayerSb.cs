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

        public bool IsTurning = false;

        public PlayerSb()
        {
            this.archy = new Archers();
            this.wardy = new Swordmen();
            this.pussy = new Peasants();
        }   
    }
}
