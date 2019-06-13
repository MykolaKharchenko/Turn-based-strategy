using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using training.Interfaces;
using training.Models.Units;

namespace training.Models
{
    public class Player //: IEnumerable
    {
        public IUnit archers;
        public IUnit swordsmen;
        public IUnit peasants;

        public bool IsTurning = false;

        public Player()
        {
            archers = new Archers();
            swordsmen = new Swordmen();
            peasants = new Peasants();
        }

        public Player(string dataPath)
        {
            // must be written..
        }
    }
}
