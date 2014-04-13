using NXT.DAL.Entities.Pokedexes;
using NXT.DAL.Entities.Species;
namespace NXT.DAL.Entities.Pokemons
{
    /// <summary>
    /// The pokedex number for a Pokemon.
    /// </summary>
    /// <remarks>
    /// Again, strictly speaking, sorted by Species and not Pokemon. Wierd tables names Veekun :-(
    /// </remarks>
    public class PokemonPokedexNumber
    {
        // PK on Species + Pokedex
        public _Species Species { get; set; }
        public Pokedex Pokedex { get; set; }
        public int Number { get; set; }
    }
}
