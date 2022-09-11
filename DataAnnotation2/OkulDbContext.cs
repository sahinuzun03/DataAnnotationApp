using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotation2
{
    public class OkulDbContext : DbContext
    {
        public OkulDbContext() : base("Server =DESKTOP-7628CQK;Database=KD12OkulDatabaseDataAnnotation;Uid=sa;Pwd=11411141;")
        {

        }

        public DbSet<Okul> Okullar { get; set; }
        public DbSet<Mudur> Mudurler { get; set; }
        public DbSet<Ogretmen> Ogretmenler { get; set; }    

        public DbSet<Sınıf> Sınıflar { get; set; }
    }
}
