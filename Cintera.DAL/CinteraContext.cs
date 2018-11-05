using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Cintera.DAL
{
    public class CinteraContext : DbContext
    {
        public CinteraContext()
            : base("CinteraContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Vehicle>()
                .Property(x => x.VehicleIdentificationNumber)
                .IsRequired()
                .HasMaxLength(17);

            base.OnModelCreating(modelBuilder);
        }
    }
}
