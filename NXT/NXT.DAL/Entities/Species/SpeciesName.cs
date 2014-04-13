using NXT.DAL.Entities.Languages;
namespace NXT.DAL.Entities.Species
{
    /// <summary>
    /// The name of a species.
    /// </summary>
    public class SpeciesName
    {
        // pk on species + language
        /// <summary>
        /// The language this name is in.
        /// </summary>
        public Language Language { get; set; }
        public _Species Species { get; set; }

        /// <summary>
        /// The name of the species.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The genus of a species (i.e, Seed pokemon)
        /// </summary>
        public string Genus { get; set; }
    }
}
