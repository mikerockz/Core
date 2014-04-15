using System.Data.Entity;
namespace NXT.DAL.EF
{
    public class NxtContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure EF mappings here
            // or create an EntityTypeConfiguration<T> class
            var thisAssembly = typeof(NxtContext).Assembly;
            modelBuilder.Configurations.AddFromAssembly(thisAssembly);
        }
    }
}
