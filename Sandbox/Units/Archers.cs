using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Unit
{
    public class Archers : Unit
    {
        public Archers() : base()
        {
            this.totalHP = this.stackSize * Config.ArcherHP;
            this.stackSpeed = Config.ArcherSpeed;
            this.Name = "Archer";
            this.HP = 50;
            this.OffensivePoints = 7;
            this.DefensePoints = 4;
        }
        public void Move(Battlefield bf)
        {
        }
        public override void SpecialSkill(Unit targetUnitStack = null, Battlefield bf = null)
        {
            SkillName = "Double Shoot";
            OffensivePoints *= 2;
            TimeoutToRefreshSkill= 3;
        }
    }
}
