using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using training.Units;

namespace training
{
    public class Player : INotifyPropertyChanged            //  -- SubModel
    {
        private IUnitStack archers;
        private IUnitStack swordmen; 
        private IUnitStack peasants;
        private bool isTurn = false;

        public IUnitStack Archers
        { get { return archers; }
            set
            {
                archers = value;
                OnPropertyChanged("Archers");
            }
        }
        public IUnitStack Swordmen
        {
            get { return swordmen; }
            set
            {
                swordmen = value;
                OnPropertyChanged("Swordmen");
            }
        }
        public IUnitStack Peasants
        {
            get { return peasants; }
            set
            {
                peasants = value;
                OnPropertyChanged("Peasants");
            }
        }

        public bool IsTurn
        {
            get { return isTurn; }
            set
            {
                isTurn = value;
                OnPropertyChanged("IsTurn");
            }
        }        

        //  new palyer
        public Player()
        {
            Archers = new IUnitStack() as Archers;
            //this.Archers.StackSize = IUnitStack.GetRandomStackSize();
            //this.Swordmen.StackSize = IUnitStack.GetRandomStackSize();
            //this.Peasants.StackSize = IUnitStack.GetRandomStackSize();
        }

        // existing palyer  
        public Player(string gamePath)
        {
            // ..load from db
        }
               
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")      // CallerMemberName - read!!!
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));         //  Invoke  - read!!!
        }

    }
}
