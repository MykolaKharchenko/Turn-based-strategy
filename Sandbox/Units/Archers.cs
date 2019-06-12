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
            totalHP = this.stackSize * Config.ArcherHP;
            stackSpeed = Config.ArcherSpeed;
            Name = "Archer";
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
            TimeoutToRefreshSkill= 3;
        }
    }
}
