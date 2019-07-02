using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using training.Models;

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

        static Random gen = new Random();
        //public static int Next
        //{
        //    get { return gen.Next(0, 500); }
        //}

        public static int Next(int upLimit)
        {
            return gen.Next(0, upLimit);
        }



        public static string ConvertToString(object Obj)
        { return JsonConvert.SerializeObject(Obj); }

        public static Player ConvertToObjectPlayer(string str)
        { return JsonConvert.DeserializeObject<Models.Player>(str); }

        public static Game ConvertToObjectGame(string str)
        { return JsonConvert.DeserializeObject<Models.Game>(str); }

        public static Battlefield ConvertToObjectBattlefield(string str)
        { return JsonConvert.DeserializeObject<Models.Battlefield>(str); }

    }
}
