using System.Collections.Generic;
namespace NXT.DAL.Entities.Abilities
{
    /// <summary>
    /// Denotes changes to an ability over time.
    /// </summary>
    public class AbilityChangelog
    {
        public int Id { get; set; }
        public Ability Ability { get; set; }
        /// <summary>
        /// The group in which this ability was changed.
        /// </summary>
        public VersionGroup ChangingGroup { get; set; }
        /// <summary>
        /// Prose describing the change.
        /// </summary>
        public ICollection<AbilityChangelogProse> Prose { get; set; }
    }
}
