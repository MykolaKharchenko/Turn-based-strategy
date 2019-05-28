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
    public class Player : INotifyPropertyChanged
    {
        private IUnitStack archers;
        private IUnitStack swordmen; 
        private IUnitStack peasants;
        

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


        private bool isTurn = false;
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
            this.Archers.StackSize = Services.GameDrive.GetRandomStackSize();
            this.Swordmen.StackSize = Services.GameDrive.GetRandomStackSize();
            this.Peasants.StackSize = Services.GameDrive.GetRandomStackSize();

        }

        public Player(string gamePath)
        {
        }
               
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")      // CallerMemberName - read!!!
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));         //  Invoke  - read!!!
        }

    }
}
