using NXT.DAL.EF.Conventions;
using System.Data.Entity;
namespace NXT.DAL.EF
{
    public class NxtContext : DbContext
    {
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
