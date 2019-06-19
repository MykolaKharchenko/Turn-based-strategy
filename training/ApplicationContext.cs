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
        public DbSet<Game> Games { get; set; }

        public ApplicationContext() : base("DefaultConnection")
        {
        }
    }
}
