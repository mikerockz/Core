using NXT.DAL.Entities.Eggs;
using NXT.DAL.Entities.Species;
namespace NXT.DAL.Entities.Pokemons
{
    /// <summary>
    /// The egg group that a Pokemon belongs to.
    /// </summary>
    /// <remarks>
    /// Strictly speaking this is based on species, not pokemon
    /// </remarks>
    public class PokemonEggGroup
    {
        // PK on species and egg group ID.
        public _Species Species { get; set; }
        public EggGroup EggGroup { get; set; }
    }
}
