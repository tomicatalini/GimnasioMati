using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataLayer.DataBase
{
    public class GymMatiContext : DbContext
    {

        
        public DbSet<SocioDTO> Socios { get; set; }

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SocioDTO>().HasKey<int>(s => s.dni)
                .Property(s => s.dni).IsRequired();
                                            
        }*/
    }
}
