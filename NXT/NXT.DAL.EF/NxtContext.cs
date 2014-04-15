using NXT.DAL.EF.Conventions;
using NXT.DAL.Entities.Regions;
using System.Data.Entity;
namespace NXT.DAL.EF
{
    public class NxtContext : DbContext
    {
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<RegionName> RegionNames { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Conventions
            var rubycaseConvention = new RubyCaseConvention();
            modelBuilder.Conventions.Add(rubycaseConvention);

            // Configure EF mappings here
            // or create an EntityTypeConfiguration<T> class
            var thisAssembly = typeof(NxtContext).Assembly;
            modelBuilder.Configurations.AddFromAssembly(thisAssembly);

        }
    }
}
