using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using training.Services;

namespace training.Models.Units
{
    [DataContract(Name = "Peasants")]
    public class Peasants : Unit
    {
        public Peasants() : base()
        {
            name = "Peasants";
            stackSpeed = StaticConfig.PeasantSpeed;
            HP = 30;
            OffensivePoints = 2;
            DefensePoints = 1;
            stackSize = StaticConfig.Next(500);
            totalHP = this.stackSize * StaticConfig.PeasantHP;
            _activeUnitImagePath = @"Images\ActiveUnits\Creature_PeasantActive.gif";
            _passiveUnitImagePath = @"Images\DefaultUnits\Creature_Peasant.gif";
        }

        public override void SpecialSkill(Unit targetUnitStack, Battlefield bf = null)
        {
            SkillName = "Trenshes";
            targetUnitStack.DefensePoints += 2;
            TimeoutToRefreshSkill = 3;
        }

        public override void Move(Battlefield bf = null)
        {
        }

    }
}
