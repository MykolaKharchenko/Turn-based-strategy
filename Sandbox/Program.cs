using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Sandbox.Unit;

namespace Sandbox
{
    public class Singleton
    {
        public string Date { get; private set; }
        public static string text = "hello";
        private Singleton()
        {
            Console.WriteLine($"Singleton ctor {DateTime.Now.TimeOfDay}");
            Date = DateTime.Now.TimeOfDay.ToString();
        }

        public static Singleton GetInstance()
        {
            Console.WriteLine($"GetInstance {DateTime.Now.TimeOfDay}");
            return Nested.instance;
        }

        private class Nested
        {
            internal static readonly Singleton instance = new Singleton();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"Main {DateTime.Now.TimeOfDay}");
            //Console.WriteLine(Singleton.text);

            //var s = new PlayerSb();

            //Console.ReadKey();

            //s.archy.SpecialSkill();
            //var ss = s.archy.UnitSize;


            PlayerSb player = new PlayerSb();





            GameSb game = new GameSb();
            Console.WriteLine("Player1  = " + game.p1.IsTurning);
            Console.WriteLine("Player2  = " + game.p2.IsTurning);

            //game.StartGame();

            Console.WriteLine("===== Player 1 =====");
            Console.WriteLine("Palyer1 Archers= "+ game.p1.archy.UnitSize.ToString());
            Console.WriteLine("Palyer1 Swordmen= "+game.p1.wardy.UnitSize.ToString());
            Console.WriteLine("Palyer1 Peasants= "+game.p1.pussy.UnitSize.ToString());

            Console.WriteLine("===== Player 2 =====");
            Console.WriteLine("Palyer2 Archers= " + game.p2.archy.UnitSize.ToString());
            Console.WriteLine("Palyer2 Swordmen= " + game.p2.wardy.UnitSize.ToString());
            Console.WriteLine("Palyer2 Peasants= " + game.p2.pussy.UnitSize.ToString());


            var archy = new Archers();
            var wardy = new Swordmen();

            int i = 1;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("===============Turn №" + i + "===========================");
                Console.WriteLine();

                Console.WriteLine("Archi : " + archy.stackSize + " units " + archy.totalHP + " HP");
                Console.WriteLine("sWardi: " + wardy.stackSize + " units " + wardy.totalHP + " HP");


                Console.WriteLine("------------------ archy ATTACK wardy ----------------");
                archy.GetDamage(wardy);
                Console.WriteLine("------------------ wardy ATTACK archy ----------------");
                wardy.GetDamage(archy);


                i++;

                if (archy.stackSize <= 0)
                {
                    Console.WriteLine("Game over.   Wardy is winner!!!");
                    break;
                }

                if (wardy.stackSize <= 0)
                {
                    Console.WriteLine("Game over.   Archy is winner!!!");
                    break;
                }
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}

