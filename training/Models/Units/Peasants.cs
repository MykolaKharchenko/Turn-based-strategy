using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using training.Services;

namespace training.Models.Units
{
    public class Peasants : Unit
    {
        public Peasants() : base()
        {
            totalHP = this.stackSize * StaticConfig.PeasantHP;
            stackSpeed = StaticConfig.PeasantSpeed;
            HP = 30;
            OffensivePoints = 2;
            DefensePoints = 1;
            Random s = new Random();
            stackSize = s.Next(51, 251);
            _activeUnitImagePath = @"Images\ActiveUnits\Creature_PeasantActive.gif";
            _passiveUnitImagePath = @"Images\DefaultUnits\Creature_Peasant.gif";
        }

        public override void SpecialSkill(Unit targetUnitStack, Battlefield bf = null)
        {
            SkillName = "Trenshes";
            targetUnitStack.DefensePoints += 2;
            TimeoutToRefreshSkill = 3;
        }
    }
}
