using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Unit
{
    public abstract class Unit : IUnit
    {
        // public int prioritet = 0|| 1 || 2 
        PlayerSb playerSB;
        public string Name = "";     //  TypesImagePath
        //Random rnd = new Random();
        bool IsActive = false;

        public int totalHP;
        public int stackSpeed;
        public int stackSize;
        public int HP;
        public int OffensivePoints;
        public int DefensePoints;
        public string SkillName { get; set; }
        public int TimeoutToRefreshSkill = 0;

        public Unit()
        {
            Random s = new Random();
            this.stackSize = s.Next(5, 51);
        }

        public void GetDamage(Unit enemy = null)
        {
            HandleDamage(this.stackSize * this.OffensivePoints, enemy);
        }

        public void HandleDamage(int damage, Unit enemy = null)
        {
            int defense = this.stackSize * this.DefensePoints;
            int diedUnits = damage / enemy.HP;
            Console.WriteLine(this.Name + " hit " + (damage - defense) + " points to " + enemy.Name);
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

        public void AbilitySpecialSkill(Unit targetUnitStack = null, Battlefield bf = null)
        {
            if (TimeoutToRefreshSkill > 0)
                return;
            else
            {
                SpecialSkill(targetUnitStack, bf);
            }
            TimeoutToRefreshSkill--;
        }
        public virtual void SpecialSkill(Unit targetUnitStack = null, Battlefield bf = null)
        {
        }
        public int GetUnitSize()
        {
            return this.stackSize;
        }
    }
}