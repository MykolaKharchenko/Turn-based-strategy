using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.UnitStack
{
    public class Archers : UnitStack
    {
        public Archers() : base()
        {
            this.totalHP = this.stackSize * Config.ArcherHP;
            this.totalDP = this.stackSize * Config.ArcherDP;
            this.stackSpeed = Config.ArcherSpeed;
            this.Name = "Archer";
            this.HP = 50;
            this.DP = 7;
        }
    }
}
