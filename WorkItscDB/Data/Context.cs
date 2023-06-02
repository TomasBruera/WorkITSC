using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkItscDB.Data
{
    public class Context : DbContext
    {
        //public DbSet<Persona> Personas => Set<Persona>();

        public Context(DbContextOptions options) : base(options)
        {

        }
    }
}
