using NXT.DAL.Entities.Regions;
using System.Data.Entity.ModelConfiguration;
namespace NXT.DAL.EF.EntityMaps
{
    public class RegionNameMap : EntityTypeConfiguration<RegionName>
    {
        public RegionNameMap()
        {
            HasKey(x => new { x.LanguageId, x.OwnerId });

            HasRequired(x => x.Language)
                .WithMany()
                .HasForeignKey(x => x.LanguageId);

            HasRequired(x => x.Owner)
                .WithMany()
                .HasForeignKey(x => x.OwnerId);

            Property(x => x.Name);

            // TODO: we can conventionalize this
            ToTable("region_names");
        }
    }
}
