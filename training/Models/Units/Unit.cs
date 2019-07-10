using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using training.Interfaces;

namespace training.Models.Units
{
    [DataContract]
    public abstract class Unit : IUnit
    {
        public string name { get; set; }

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
        public int StackSpeed { get { return stackSpeed; } }
        public string Name { get { return name; } }
        public bool IsAlive { get { return (stackSize) > 0; } }
      
        public string passiveUnitImagePath { get { return _passiveUnitImagePath; } set { value = _passiveUnitImagePath; } }
        public string activeUnitImagePath { get { return _activeUnitImagePath; } set { value = _activeUnitImagePath; } }

        public bool IsActive { get; set; }

        public Unit()
        {
            this.stackSize = Services.StaticConfig.Next(0);
            activeUnitImagePath = "";
            passiveUnitImagePath = "";
            IsActive = false;
        }

        public void Act(Unit enemt = null, Battlefield bf = null)
        {
        }

        public void GetDamage(Unit enemy = null)
        {
            HandleDamage(this.stackSize * this.OffensivePoints, enemy);
        }

        protected virtual void HandleDamage(int damage, Unit enemy = null)
        {
            int defense = this.stackSize * this.DefensePoints;
            int diedUnits = damage / enemy.HP;
            if ((enemy.totalHP - damage) % enemy.HP != 0)
                enemy.stackSize = (enemy.totalHP - damage) / enemy.HP + 1;
            else
                enemy.stackSize = (enemy.totalHP - damage) / enemy.HP;
            enemy.totalHP -= damage >= defense ? damage - defense : 1;
        }

        public virtual void Move(Battlefield bf = null)
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
