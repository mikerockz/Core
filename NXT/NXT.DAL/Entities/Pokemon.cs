using System.Collections.Generic;
namespace NXT.DAL.Entities
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
        public Species Species { get; set; }
        public IEnumerable<PokemonStat> Stats { get; set; }
        public IEnumerable<PokemonAbility> Abilities { get; set; }
        public IEnumerable<PokemonType> Types { get; set; }
        public IEnumerable<PokemonForm> Forms { get; set; }
        public IEnumerable<PokemonItem> Items { get; set; }
        public IEnumerable<PokemonMove> Moves { get; set; }
        public IEnumerable<PokemonGameIndice> GameIndicies { get; set; }
    }
}
