using NXT.DAL.Entities.Languages;
namespace NXT.DAL.Entities.Abilities
{
    /// <summary>
    /// Flavour text that is displayed in the pokemon overview - more basic than Prose.
    /// </summary>
    public class AbilityFlavorText
    {
        // pk on ability + version group + language
        public Ability Ability { get; set; }
        public VersionGroup VersionGroup { get; set; }
        public Language Language { get; set; }
        public string FlavorText { get; set; }
    }
}
