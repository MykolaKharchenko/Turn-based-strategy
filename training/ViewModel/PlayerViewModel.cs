using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using training.Interfaces;

namespace training.ViewModel
{
    public class PlayerViewModel : IPlayer, INotifyPropertyChanged 
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


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string prop = "")      // CallerMemberName - read!!!
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
