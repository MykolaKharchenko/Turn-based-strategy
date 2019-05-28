using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training.Services
{
    public interface IFileService
    {
        Game Open(string filename);
        void Save(string filename, Game Game);
    }
}
