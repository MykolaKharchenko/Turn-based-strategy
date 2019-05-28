using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace training.Units
{
    public class IUnitStack
    {
        int healthPoints { get; set; }
        int damagePoints { get; set; }
        private int stackSize;
        
        public int totalHealthPoint
        {
            get { return this.totalHealthPoint; }
            set
            {
                totalHealthPoint = healthPoints * stackSize;
            }
        }

        public int StackSize
        {
            get { return stackSize; }
            set { stackSize = value; }
        }
    }

    public class Archers : IUnitStack
    {
        public int healthPoints { get; set; } = 5;
        public int damagePoints { get; set; } = 7;
   //     public int totalHealthPoint { get; set; } = healthPoints*6;
    }

    public class Swordmen : IUnitStack
    {
        public int healthPoints { get; set; } = 10;
        public int damagePoints { get; set; } = 5;        
    }

    public class Peasants: IUnitStack
    {
        public int healthPoints { get; set; } = 3;
        public int damagePoints { get; set; } = 2;
    }
}
