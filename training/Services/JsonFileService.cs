using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using training.Models;

namespace training.Services
{
    public class JsonFileService : IFileService
    {
        public Game Open(string filename)
        {
            Game _game = new Game();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Game));

            using (FileStream fileStream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                _game = jsonFormatter.ReadObject(fileStream) as Game;
            }
            return _game;
        }

        public void Save(string _filename, Game _game)
        {
            DataContractJsonSerializer _jsonFormatter = new DataContractJsonSerializer(typeof(Game));


            FileStream fs = new FileStream(_filename, FileMode.Create);
            _jsonFormatter.WriteObject(fs, null);
            _jsonFormatter.WriteObject(fs, _game);




            using (FileStream _filestream = new FileStream(_filename, FileMode.Create))
            {
                _jsonFormatter.WriteObject(_filestream, _game);
            }
        }
    }
}
