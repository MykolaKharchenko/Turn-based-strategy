using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.UnitStack
{
    public class Swordmen :UnitStack
    {
        public Swordmen() : base()
        {
            this.totalHP = this.stackSize * Config.SwordmanHP;
            this.totalDP = this.stackSize * Config.SwordmanDP;
            this.stackSpeed = Config.SwordmanSpeed;
            this.Name = "Swordmen";
            this.HP = 100;
            this.DP = 5;
        }
    }
}
