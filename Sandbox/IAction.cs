using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public interface IAction
    {
        void GetDamage(Unit.UnitStack enemy);

        void Move(Battlefield bf);

        void AbilitySpecialSkill(Unit.UnitStack targetUnitStack, Battlefield bf);

    }
}
