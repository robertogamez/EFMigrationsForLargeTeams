using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cintera.DAL
{
    public class CinteraContext : DbContext
    {
        public CinteraContext()
            : base("CinteraContext")
        {

        }

        public DbSet<Case> Cases { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions
                .Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Sighting>()
                .Property(x => x.Address)
                .HasMaxLength(256)
                .IsRequired();
            modelBuilder.Entity<Vehicle>()
                .Property(x => x.VehicleIdentificationNumber)
                .IsRequired()
                .HasMaxLength(17);

            base.OnModelCreating(modelBuilder);
        }
    }
}
