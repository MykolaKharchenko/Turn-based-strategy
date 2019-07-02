using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using training.Services;

namespace training.Models.Units
{
    [DataContract (Name ="Archers")]
    public class Archers : Unit
    {
        public Archers() : base()
        {
            name = "Archers";
            totalHP = this.stackSize * StaticConfig.ArcherHP;
            stackSpeed = StaticConfig.ArcherSpeed;
            HP = 50;
            OffensivePoints = 7;
            DefensePoints = 4;
            Random s = new Random();
            stackSize = StaticConfig.Next(100);
            _activeUnitImagePath = @"Images\ActiveUnits\Creature_ArcherActive.gif";
            _passiveUnitImagePath = @"Images\DefaultUnits\Creature_Archer.gif";
        }

        public override void SpecialSkill(Unit targetUnitStack = null, Battlefield bf = null)
        {
            SkillName = "Double Shoot";
            OffensivePoints *= 2;
            TimeoutToRefreshSkill = 3;
        }
    }
}
