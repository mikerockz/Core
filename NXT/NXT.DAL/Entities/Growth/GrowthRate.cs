using System.Collections.Generic;
namespace NXT.DAL.Entities.Growth
{
    /// <summary>
    /// The growth rate of a Pokémon
    /// </summary>
    public class GrowthRate
    {
        public int Id { get; set; }
        public string Identifier { get; set; }
        /// <summary>
        /// LaTeX formula for pokemon's growth.
        /// </summary>
        public string Formula { get; set; }
        public ICollection<GrowthRateProse> Prose { get; set; }
    }
}
