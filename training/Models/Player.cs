using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using training.Interfaces;
using training.Models.Units;

namespace training.Models
{
    public class Player : IPlayer, INotifyPropertyChanged
    {
        private IUnit archers;
        public IUnit Archers
        {
            get { return archers; }
            set
            {
                archers = value;
                OnPropertyChanged("Archers");
            }
        }

        private IUnit swordsmen;
        public IUnit Swordmen
        {
            get { return swordsmen; }
            set
            {
                swordsmen = value;
                OnPropertyChanged("Swordmen");
            }
        }

        private IUnit peasants;
        public IUnit Peasants
        {
            get { return peasants; }
            set
            {
                peasants = value;
                OnPropertyChanged("Swordmen");
            }
        }
               
        private List<IUnit> unitsStacks;
        public List<IUnit> UnitsStacks
        {
            get { return unitsStacks; }
            set
            {
                unitsStacks = value;
            }
        }

        protected List<IUnit> InitUnitsStack()
        {            
            List<IUnit> _UnitsStack = new List<IUnit>() { Swordmen, Archers,Peasants };
            _UnitsStack =  _UnitsStack.OrderByDescending(x => x.StackSpeed).ToList();
            return _UnitsStack;
        }

        public IUnit GetUnitForTurning()
        {
            if (this.IsTurning)
            {
                UnitsStacks.First().IsActive = true;        // первого Юнита делаем "активным"

                UnitsStacks.Add(UnitsStacks[0]);            // прокидываем копию первого Юнита в конец очереди 
                var res = UnitsStacks[0];
                UnitsStacks.RemoveAt(0);                    // удаляем первого в Очереди

                return res;
            }
            else return UnitsStacks[0];
        }
        public bool IsTurning;

        #region ctors Player
        public Player()
        {
            archers = new Archers();
            swordsmen = new Swordmen();
            peasants = new Peasants();

            unitsStacks = InitUnitsStack();
            IsTurning = false;
        }

        public Player(string dataPath)
        {
            // must be written..
        }
        #endregion
                
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string prop = "")      // CallerMemberName - read!!!
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));         
        }
    }
}
