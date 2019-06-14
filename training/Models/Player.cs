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
        public IUnit archers;
        public IUnit swordsmen;
        public IUnit peasants;

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
