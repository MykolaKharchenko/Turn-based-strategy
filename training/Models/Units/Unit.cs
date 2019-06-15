using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using training.Interfaces;

namespace training.Models.Units
{
    public abstract class Unit : IUnit
    {
        public int totalHP;
        public int stackSpeed;
        public int stackSize;
        public int HP;
        public int OffensivePoints;
        public int DefensePoints;
        public string SkillName { get; set; }
        public int TimeoutToRefreshSkill = 0;

        public string attackIconPath = @"Images\sword.png";
        public string moveIconPath = @"Images\running.png";
        public string spesial_skillIconPath = @"Images\star.png";
        protected string _activeUnitImagePath ="";
        protected string _passiveUnitImagePath="";
            
        public int UnitSize { get { return stackSize; } }
        public bool IsAlive { get { return (stackSize) > 0; } }
        public bool IsActive { get; }   //  !!!!  i don't any solution

        public string passiveUnitImagePath { get { return _passiveUnitImagePath; }  set { value = _passiveUnitImagePath; } }
        public string activeUnitImagePath { get { return _activeUnitImagePath; } set { value = _activeUnitImagePath; } }

        public Unit()
        {
            Random s = new Random();
            this.stackSize = s.Next(5, 51);
            activeUnitImagePath = "";
            passiveUnitImagePath = "";
        }

        public void GetDamage(Unit enemy = null)
        {
            HandleDamage(this.stackSize * this.OffensivePoints, enemy);
        }

        public void HandleDamage(int damage, Unit enemy = null)
        {
            int defense = this.stackSize * this.DefensePoints;
            int diedUnits = damage / enemy.HP;
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
    }
}
