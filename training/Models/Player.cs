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
    public class Player :INotifyPropertyChanged
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

        public bool IsTurning = false;

        public Player()
        {
            archers = new Archers();
            swordsmen = new Swordmen();
            peasants = new Peasants();
        }

        public Player(string dataPath)
        {
            // must be written..
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string prop = "")      // CallerMemberName - read!!!
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));         
        }
    }
}
