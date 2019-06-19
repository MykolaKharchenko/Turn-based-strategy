using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using training;
using Newtonsoft.Json;
using training.Models;
using System.IO;
using System.ComponentModel;
//using System.Runtime.Serialization.Json;

namespace Sandbox
{
    //    public class ApplicationContextSb   : DbContext
    //    {
    //        //public DbSet<Proto> ProtoDbSet { get; set; }
    //        //public DbSet<Game> Games { get; set; }
    //        public DbSet<ProtoGame> ProtoGamesDbSet { get; set; }

    //        public ApplicationContext() : base("DefaultConnection")
    //        {
    //            //Games.Load();
    //            var g1 = new Game();
    //            var s1 = JsonConvert.SerializeObject(g1);



    //            var protogame1 = new ProtoGame();
    //            ProtoGamesDbSet.Load();
    //            ProtoGamesDbSet.Add(new ProtoGame());
    //            ProtoGamesDbSet.Add(protogame1);
    //            ProtoGamesDbSetSaveChanges();

    //            var testValue = ProtoGamesDbSet.Local.ToBindingList();
    //        }
    //        public void Save(string _filename, Game _game)
    //        {
    //            DataContractJsonSerializer _jsonFormatter = new DataContractJsonSerializer(typeof(Game));
    //            using (FileStream _filestream = new FileStream(_filename, FileMode.Create))
    //            {
    //                _jsonFormatter.WriteObject(_filestream, _game);
    //            }
    //        }
    //    }

    public class ProtoGame : INotifyPropertyChanged
    {
        //[Key]
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
            get { return JsonConvert.SerializeObject(playerLeft); }
            set
            {
                playerLeft = JsonConvert.DeserializeObject<Player>(value);
                OnPropertyChanged("ProtoPlayerLeft");
            }
        }

        public Player playerRight;
        public string ProtoPlayerRight
        {
            get { return JsonConvert.SerializeObject(playerRight); }
            set
            {
                playerRight = JsonConvert.DeserializeObject<Player>(value);
                OnPropertyChanged("ProtoPlayerRight");
            }
        }

        public Battlefield battlefield = new Battlefield();
        public string ProtoBattlefield
        {
            get { return JsonConvert.SerializeObject(battlefield); }
            set
            {
                battlefield = JsonConvert.DeserializeObject<Battlefield>(value);
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

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string prop = "")      // CallerMemberName - read!!!
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }

    public class Proto : INotifyPropertyChanged
    {
        //[Key]
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
