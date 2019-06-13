using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training.Services
{
    public static class StaticConfig
    {
        public static List<string> UnitTypes = new List<string> { "Archer", "Swordman", "Peasant" };

        public static int ArcherHP = 50;
        public static int SwordmanHP = 100;
        public static int PeasantHP = 30;

        public static int ArcherDP = 7;
        public static int SwordmanDP = 5;
        public static int PeasantDP = 2;

        public static int ArcherSpeed = 4;
        public static int SwordmanSpeed = 3;
        public static int PeasantSpeed = 2;
    }
}
