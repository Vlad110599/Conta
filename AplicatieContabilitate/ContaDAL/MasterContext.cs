using ContaDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaDAL
{
    public class MasterContext : DbContext
    {
        public DbSet<User> Utilizator { get; set; }

        public DbSet<Punct1> Point1 { get; set; }

        public DbSet<Punct2> Point2 { get; set; }

        public DbSet<Punct3> Point3 { get; set; }

        public DbSet<Punct4> Point4 { get; set; }

        public DbSet<Punct5> Point5 { get; set; }

        public DbSet<Punct6> Point6 { get; set; }


        public MasterContext()
            : base("defaultConnection")
        {

        }
    }
}
