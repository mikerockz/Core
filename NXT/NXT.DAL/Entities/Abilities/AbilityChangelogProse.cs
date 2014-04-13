using NXT.DAL.Entities.Languages;
namespace NXT.DAL.Entities.Abilities
{
    /// <summary>
    /// Information describing a change to an ability over generations.
    /// </summary>
    public class AbilityChangelogProse
    {
        // pk on ability changelog + language
        public AbilityChangelog Changelog { get; set; }
        public Language Language { get; set; }
        public string Effect { get; set; }
    }
}
