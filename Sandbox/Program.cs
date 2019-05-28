using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
            Console.WriteLine($"Main {DateTime.Now.TimeOfDay}");
            Console.WriteLine(Singleton.text);
            Console.Read();
        }
    }
}
