using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace training
{
    public class Game : INotifyPropertyChanged
    {
        private Player palyerLeft;
        private Player palyerRight;
        private int gameId;
        private string pathAddress;

        public Player PlayerLeft
        {
            get { return PlayerLeft; }
            set
            {
                palyerLeft = value;
                OnPropertyChanged("PlayerLeft");                
            }
        }

        public Player PlayerRight
        {
            get { return PlayerRight; }
            set
            {
                palyerRight = value;
                OnPropertyChanged("PlayerRight");                
            }
        }

        public string PathAddress
        {
            get { return pathAddress; }
            set
            {
                pathAddress = value;
                OnPropertyChanged("PathAddress");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")      // CallerMemberName - read!!!
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));         //  Invoke  - read!!!
        }

    }
}
