using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using training.Services;

namespace training.Models.Units
{
    [DataContract(Name = "Swordmen")]
    public class Swordmen : Unit
    {
        public Swordmen() : base()
        {
            name = "Swordmen";
            stackSpeed = StaticConfig.SwordmanSpeed;
            HP = 100;
            OffensivePoints = 5;
            DefensePoints = 8;
            stackSize = StaticConfig.Next(50);
            totalHP = this.stackSize * StaticConfig.SwordmanHP;
            _activeUnitImagePath = @"Images\ActiveUnits\Creature_SwordsmanActive.gif";
            _passiveUnitImagePath = @"Images\DefaultUnits\Creature_Swordsman.gif";
        }

        public override void SpecialSkill(Unit targetUnitStack = null, Battlefield bf = null)
        {
            SkillName = "Marshes";
            this.stackSpeed *= 2;
            TimeoutToRefreshSkill = 3;
        }

        public override void Move(Battlefield bf = null)
        {
        }
    }
}
