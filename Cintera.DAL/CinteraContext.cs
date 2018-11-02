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

        public DbSet<Case> Cases { get; set; }
        public DbSet<Sighting> Sightings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Sighting>()
                .Property(x => x.Address)
                .HasMaxLength(256)
                .IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
