using NXT.DAL.Entities.Languages;
namespace NXT.DAL.Entities.Species
{
    /// <summary>
    /// The flavour summary for a Pokemon.
    /// This has no real use. Only here for completeness
    /// </summary>
    public class SpeciesFlavorSummary
    {
        // Compound pk on Species + Language
        public _Species Species { get; set; }
        public Language Language { get; set; }
        public string FlavorSummary { get; set; }
    }
}
