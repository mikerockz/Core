using NXT.DAL.Entities.Languages;
namespace NXT.DAL.Entities.Species
{
    /// <summary>
    /// The flavour text for a Pokémon. This is displayed in the Pokédex.
    /// </summary>
    public class SpeciesFlavorText
    {
        // PK on Species, Version and Language
        public _Species Species { get; set; }
        public GameVersion Version { get; set; }
        public Language Language { get; set; }

        public string FlavorText { get; set; }
    }
}
