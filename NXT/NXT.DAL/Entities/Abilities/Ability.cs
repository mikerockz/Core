using NXT.DAL.Entities.Generations;
using System.Collections.Generic;
namespace NXT.DAL.Entities.Abilities
{
    /// <summary>
    /// An ability.
    /// </summary>
    public class Ability
    {
        public int Id { get; set; }
        public string Identifier { get; set; }
        /// <summary>
        /// The generation the ability was introduced in.
        /// </summary>
        public Generation Generation { get; set; }
        /// <summary>
        /// Unknown as to what it does. Needs investigation.
        /// </summary>
        public bool IsMainSeries { get; set; }
        public ICollection<AbilityName> Names { get; set; }
        public ICollection<AbilityProse> Prose { get; set; }
        public ICollection<AbilityFlavorText> FlavorText { get; set; }
        public ICollection<AbilityChangelog> Changelog { get; set; }
    }
}
