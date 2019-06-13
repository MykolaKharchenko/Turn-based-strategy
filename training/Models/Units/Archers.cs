using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using training.Services;

namespace training.Models.Units
{
    public class Archers : Unit
    {
        public Archers() : base()
        {
            totalHP = this.stackSize * StaticConfig.ArcherHP;
            stackSpeed = StaticConfig.ArcherSpeed;
            HP = 50;
            OffensivePoints = 7;
            DefensePoints = 4;
            Random s = new Random();
            stackSize = s.Next(10, 101);
        }
        public void Move(Battlefield bf)
        {
        }
        public override void SpecialSkill(Unit targetUnitStack = null, Battlefield bf = null)
        {
            SkillName = "Double Shoot";
            OffensivePoints *= 2;
            TimeoutToRefreshSkill = 3;
        }
    }
}
