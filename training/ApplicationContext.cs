using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using training.Models;

namespace training
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Game> Games { get; set; }
        //public DbSet<Player> Players { get; set; }

        public ApplicationContext() : base("DefaultConnection")
        {
        }
    }
}
