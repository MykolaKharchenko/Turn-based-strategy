using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public interface IUnit
    {
        void GetDamage(Unit.Unit enemy = null);

        void Move(Battlefield bf= null);

        void SpecialSkill(Unit.Unit targetUnitStack = null, Battlefield bf = null);

        int UnitSize { get; }

        bool IsAlive { get; }
        bool IsActive { get; }

    }
}
