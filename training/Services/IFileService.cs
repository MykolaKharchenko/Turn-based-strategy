using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using training.Models;

namespace training.Services
{
    public interface IFileService
    {
        Game Open(string filename);
        void Save(string filename, Game Game);
    }
}
