using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Unit
{
    public class Swordmen :Unit
    {
        public Swordmen() : base()
        {
            this.totalHP = this.stackSize * Config.SwordmanHP;
            this.stackSpeed = Config.SwordmanSpeed;
            this.Name = "Swordmen";
            this.HP = 100;
            this.OffensivePoints = 5;
            this.DefensePoints = 8;
    }

        public void Move(Battlefield bf)
        {
        }
        public override void SpecialSkill(Unit targetUnitStack = null, Battlefield bf = null)
        {
            SkillName = "Marshes";
            this.stackSpeed *= 2;
            TimeoutToRefreshSkill = 3;
        }
    }
}
