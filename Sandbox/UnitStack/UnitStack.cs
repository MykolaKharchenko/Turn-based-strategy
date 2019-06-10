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
        public int stackSpeed;
        public int stackSize;
        public int HP;
        public int OffensivePoints;
        public int DefensePoints;
        public string SkillName { get; set; }
        public int TimeoutToRefreshSkill = 0;

        public UnitStack()
        {
            this.stackSize = rnd.Next(5, 51);
        }

        public void GetDamage(UnitStack enemy = null)
        {
            HandleDamage(this.stackSize * this.OffensivePoints, enemy);
        }

        public void HandleDamage(int damage, UnitStack enemy = null)
        {
            int defense = this.stackSize * this.DefensePoints;
            int diedUnits = damage / enemy.HP;
            Console.WriteLine(this.Name + " hit " + (damage-defense) + " points to " + enemy.Name);
            Console.WriteLine(enemy.Name + " lose " + diedUnits + " units");
            if ((enemy.totalHP - damage) % enemy.HP != 0)
                enemy.stackSize = (enemy.totalHP - damage) / enemy.HP + 1;
            else
                enemy.stackSize = (enemy.totalHP - damage) / enemy.HP;
            enemy.totalHP -= damage >= defense ? damage - defense : 1;
        }

        public void Move(Battlefield bf = null)
        {
        }

        public void AbilitySpecialSkill(UnitStack targetUnitStack = null, Battlefield bf = null)
        {
            if (TimeoutToRefreshSkill > 0)
                return;
            else
            {
                SpecialSkill(targetUnitStack,bf);
            }
        }
        public virtual void SpecialSkill(UnitStack targetUnitStack = null, Battlefield bf = null)
        {
        }

    }
}