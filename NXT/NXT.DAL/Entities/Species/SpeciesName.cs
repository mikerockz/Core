using NXT.DAL.Entities.Names;
namespace NXT.DAL.Entities.Species
{
    /// <summary>
    /// The name of a species.
    /// </summary>
    public class SpeciesName : AbstractName<_Species>
    {
        // pk on species + language
        /// <summary>
        /// The genus of a species (i.e, Seed pokemon)
        /// </summary>
        public string Genus { get; set; }
    }
}
