using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using training.Models;

namespace training
{
    public class ApplicationContext : DbContext
    {
        //public DbSet<Proto> ProtoDbSet { get; set; }
        //public DbSet<Game> Games { get; set; }
        public DbSet<ProtoGame> ProtoGamesDbSet { get; set; }

        public ApplicationContext() : base("DefaultConnection")
        {
            var protogame1 = new ProtoGame();
            ProtoGamesDbSet.Load();
            ProtoGamesDbSet.Add(new ProtoGame());
            ProtoGamesDbSet.Add(protogame1);
            SaveChanges();

            var testValue = ProtoGamesDbSet.Local.ToBindingList();
        }
    }

    public class ProtoGame : INotifyPropertyChanged
    {
        [Key]
        public int GameId { get; set; }
        private string pathGameAddress;
        public string PathGameAddress
        {
            get { return pathGameAddress; }
            set
            {
                pathGameAddress = value;
                OnPropertyChanged("PathGameAddress");
            }
        }

        public Player playerLeft;       // must be private
        public string ProtoPlayerLeft
        {
            get { return ConvertToString(playerLeft); }
            set
            {
                playerLeft = ConvertToObjectPlayer(value);
                OnPropertyChanged("ProtoPlayerLeft");
            }
        }

        public Player playerRight;    
        public string ProtoPlayerRight
        {
            get { return ConvertToString(playerRight); }
            set
            {
                playerRight = ConvertToObjectPlayer(value);
                OnPropertyChanged("ProtoPlayerRight");
            }
        }

        public Battlefield battlefield = new Battlefield();   
        public string ProtoBattlefield
        {
            get { return ConvertToString(battlefield); }
            set
            {
                battlefield = ConvertToObjectBattlefield(value);
                OnPropertyChanged("ProtoBattlefield");
            }
        }

        private int turnCounter;
        public int TurnCounter
        {
            get { return turnCounter; }
            set
            {
                turnCounter = value;
                OnPropertyChanged("TurnCounter");
            }
        }

        public ProtoGame()
        {
            playerLeft = new Player();
            playerRight = new Player();
        }

        public static string ConvertToString(object Obj)
        {
            return JsonConvert.SerializeObject(Obj);
        }
        public static Player ConvertToObjectPlayer(string str)
        {
            return JsonConvert.DeserializeObject<Player>(str);
        }
        public static Battlefield ConvertToObjectBattlefield(string str)
        {
            return JsonConvert.DeserializeObject<Battlefield>(str);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string prop = "")      // CallerMemberName - read!!!
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }

    public class Proto : INotifyPropertyChanged
    {
        [Key]
        public int Numb { get; set; }
        private string str;
        public string Str
        {
            get { return str; }
            set
            {
                str = value;
                OnPropertyChanged("Str");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string prop = "")      // CallerMemberName - read!!!
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }  // for checking of connection to db 

}
