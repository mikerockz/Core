using NXT.DAL.Entities.Languages;
namespace NXT.DAL.Entities.Growth
{
    /// <summary>
    /// Basic description of the resulting growth rate curve of the owning growth rate.
    /// </summary>
    public class GrowthRateProse
    {
        // PK on language + growth rate
        public GrowthRate GrowthRate { get; set; }
        public Language Language { get; set; }
        public string Name { get; set; }
    }
}
