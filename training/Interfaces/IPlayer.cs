using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training.Interfaces
{
    public interface IPlayer
    {
        IUnit Archers { get; set; }
        IUnit Swordmen { get; set; }
        IUnit Peasants { get; set; }

        IUnit GetUnitForTurning();
       //Queue<IUnit> QueueForTurn { get; set; }
    }
}
