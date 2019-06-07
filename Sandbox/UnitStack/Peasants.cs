using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.UnitStack
{
    public class Peasants :UnitStack
    {
        public Peasants()
        {
            this.totalHP = this.stackSize * Config.PeasantHP;
            this.totalDP = this.stackSize * Config.PeasantDP;
            this.stackSpeed = Config.PeasantSpeed;
            this.Name = "Peasant";
            this.HP = 30;
            this.DP = 2;
        }
    }
}
