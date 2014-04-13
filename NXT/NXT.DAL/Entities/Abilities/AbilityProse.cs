using NXT.DAL.Entities.Languages;
namespace NXT.DAL.Entities.Abilities
{
    /// <summary>
    /// Human-friendly information about an ability, displayed under the ability in the pokemon overview.
    /// </summary>
    public class AbilityProse
    {
        // PK on ability + language
        public Ability Ability { get; set; }
        public Language Language { get; set; }
        public string Effect { get; set; }
        public string ShortEffect { get; set; }
    }
}
