using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using training.Models.Units;
using training.Models;

namespace training.Interfaces
{    
    public interface IUnit
    {
        int UnitSize { get; }
        int StackSpeed { get;  }
        bool IsAlive { get; }
        bool IsActive { get; set; } 
        bool IsSpecSkillACtive { get; set; }

        string passiveUnitImagePath { get; set; }
        string activeUnitImagePath { get; set; }
        string name { get; set; }

        void GetDamage(Unit enemy = null);
        void Move(Battlefield bf = null);
        void SpecialSkill(Unit targetUnitStack = null, Battlefield bf = null);
        bool AbilitySpecialSkill(Unit targetUnitStack = null, Battlefield bf = null);
    }
}
