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

            modelBuilder.Entity<DnaLab>()
                .Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Region>()
                .Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<Region>()
                .HasOptional(x => x.Parent)
                .WithMany()
                .HasForeignKey(x => x.ParentId);

            modelBuilder.Entity<AncestorRegion>()
                .ToTable("V_AncestorRegion")
                .HasKey(x => new { x.RegionId, x.AncestorRegionId });
            modelBuilder.Entity<AncestorRegion>()
                .HasRequired(x => x.AncestorRegionRef)
                .WithMany()
                .HasForeignKey(x => x.AncestorRegionId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Case> Cases { get; set; }
        public DbSet<DnaSample> DnaSamples { get; set; }
        public DbSet<DnaSampleStatus> DnaSampleStatus { get; set; }
    }
}
