using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Unit
{
    public class Peasants :Unit
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
        public override void SpecialSkill(Unit targetUnitStack, Battlefield bf = null)
        {
            SkillName = "Trenshes";
            targetUnitStack.DefensePoints += 2;
            TimeoutToRefreshSkill = 3;
        }
    }
}
