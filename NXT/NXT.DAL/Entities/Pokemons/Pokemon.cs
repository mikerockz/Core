using NXT.DAL.Entities.Species;
using System.Collections.Generic;
namespace NXT.DAL.Entities.Pokemons
{
    /// <summary>
    /// The Pokemon entity in Veekun.
    /// </summary>
    public class Pokemon
    {
        public int Id { get; set; }
        public bool IsDefault { get; set; }
        public string Identifier { get; set; }

        public float Height { get; set; }
        public float Weight { get; set; }

        public int BaseExperience { get; set; }
        public int Order { get; set; }

        // Foreign 
        public _Species Species { get; set; }
        public ICollection<PokemonStat> Stats { get; set; }
        public ICollection<PokemonAbility> Abilities { get; set; }
        public ICollection<PokemonType> Types { get; set; }
        public ICollection<PokemonForm> Forms { get; set; }
        public ICollection<PokemonItem> Items { get; set; }
        public ICollection<PokemonMove> Moves { get; set; }
        public ICollection<PokemonGameIndice> GameIndicies { get; set; }
    }
}
