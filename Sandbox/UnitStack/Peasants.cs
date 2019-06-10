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
            this.stackSpeed = Config.PeasantSpeed;
            this.Name = "Peasant";
            this.HP = 30;
            this.OffensivePoints = 2;
            this.DefensePoints = 1;
        }
        public void Move(Battlefield bf)
        {
        }
        public override void SpecialSkill(UnitStack targetUnitStack, Battlefield bf = null)
        {
            SkillName = "Trenshes";
            targetUnitStack.DefensePoints += 2;
            TimeoutToRefreshSkill = 3;
        }
    }
}
