using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Unit
{
    public class Peasants :Unit
    {
        public Peasants(): base()
        {
            totalHP = this.stackSize * Config.PeasantHP;
            stackSpeed = Config.PeasantSpeed;
            Name = "Peasant";
            HP = 30;
            OffensivePoints = 2;
            DefensePoints = 1;
            Random s = new Random();
            stackSize = s.Next(51, 251);
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
