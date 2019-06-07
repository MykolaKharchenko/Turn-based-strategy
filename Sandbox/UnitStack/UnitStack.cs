using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.UnitStack
{
    public abstract class UnitStack
    {
        // public int prioritet = 0|| 1 || 2 
        PlayerSb playerSB;
        public string Name = "";     //  TypesImagePath
        Random rnd = new Random();
        bool IsActive = false;
               
        public int totalHP;
        public int totalDP;
        public int stackSpeed;
        public int stackSize;
        public int HP;
        public int DP;

        public UnitStack()
        {
            this.stackSize = rnd.Next(5, 51);
        }

        public void GetDamage(UnitStack enemy = null)
        {
            //HandleDamage(this.totalDP,enemy);
            HandleDamage(this.stackSize*this.DP, enemy);
        }

        public void HandleDamage(int damage, UnitStack enemy = null)
        {
            Console.WriteLine(this.Name + " hit " + damage + " points to "+ enemy.Name);
            int wouded  = damage / enemy.HP;
            Console.WriteLine(enemy.Name + " lose " + wouded + " units");
            //enemy.stackSize = (enemy.totalHP-damage)/enemy.HP+1;
            enemy.stackSize -= wouded;
            enemy.totalHP -= damage;
        }
    }
}
