using System.ComponentModel.DataAnnotations.Schema;
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

            modelBuilder.Entity<DnaSampleStatus>()
                .Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<DnaSampleStatus>()
                .Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(10);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Case> Cases { get; set; }
        public DbSet<DnaSample> DnaSamples { get; set; }
    }
}
