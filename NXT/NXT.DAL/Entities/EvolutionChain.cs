using NXT.DAL.Entities.Items;
using NXT.DAL.Entities.Species;
using System.Collections.Generic;
namespace NXT.DAL.Entities
{
    /// <summary>
    /// An evolution chain that shows a Pokemon can evolve.
    /// </summary>
    public class EvolutionChain
    {
        public int Id { get; set; }
        /// <summary>
        /// The item that must be held by a breeding pair in order to produce the baby form of this Pokemon
        /// (i.e, Snorlax holding a Full Incense will produce a Munchlax Egg when breeding).
        /// </summary>
        public Item BabyTriggerItem { get; set; }
        /// <summary>
        /// Members of the evolution chain.
        /// </summary>
        public IEnumerable<_Species> Members { get; set; }
    }
}
