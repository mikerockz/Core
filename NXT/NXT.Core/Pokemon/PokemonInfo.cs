using NXT.Core.Abilities;
using NXT.Core.Mechanics;
using NXT.Core.Moves;
using NXT.Core.World;
using System.Collections.Generic;
namespace NXT.Core.Pokemon
{
    /// <summary>
    /// Information about a Pokemon that has not been created. A template, if you will.
    /// </summary>
    /// <remarks>
    /// This is a complex type that is created by merging multiple tables from the Veekun database into
    /// one type. The result of this means that it is immutable. There should never be a way to convert
    /// PokemonInfo directly into a database entity, as a result.
    /// </remarks>
    public class PokemonInfo
    {
        /// <summary>
        /// The Id of the PokemonInfo instance
        /// </summary>
        /// <remarks>
        /// This is the Id of the pokemons table
        /// </remarks>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public float Height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public float Weight { get; set; }
        /// <summary>
        /// The name of this Pokemon
        /// </summary>
        /// <remarks>
        /// This is the English name.
        /// </remarks>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int BaseExperience { get; set; }
        /// <summary>
        /// The order of this pokemon relative to it's other forms
        /// </summary>
        /// <remarks>
        /// This is relative to the evolution chain of a Pokemon.
        /// For example, Bulbasaur would be 1. Ivysaur would be 2..
        /// </remarks>
        public int Order { get; set; }
        /// <summary>
        /// Whether or not this Pokemon is the default form.
        /// </summary>
        /// <remarks>
        /// This shouldn't belong here, it is just here for completeness.
        /// We should put this property on a Form object instead.
        /// </remarks>
        public bool IsDefault { get; set; }
        /// <summary>
        /// Abilities that this Pokemon can learn.
        /// </summary>
        /// <remarks>
        /// Lazy evaluation is a candidate here
        /// </remarks>
        public IEnumerable<AbilityInfo> Abilities { get; set; }
        /// <summary>
        /// Moves that this Pokemon can learn.
        /// </summary>
        /// <remarks>
        /// Lazy evaluation
        /// </remarks>
        public IEnumerable<MoveInfo> Moves { get; set; }
        /// <summary>
        /// The habitat that the Pokemon prefers.
        /// </summary>
        /// <remarks>
        /// This is Pokedex entry data, really - perhaps we should put this and other pokedex data in a separate
        /// class (incl Height, Weight, Color etc)
        /// </remarks>
        public Habitat Habitat { get; set; }
        /// <summary>
        /// The types that this Pokemon is.
        /// </summary>
        public IEnumerable<Type> Types { get; set; }
    }
}
