using NXT.DAL.Entities.Pokemons;
using System.Collections.Generic;
namespace NXT.DAL.Entities.Species
{
    /// <summary>
    /// The Species entity in Veekun.
    /// </summary>
    /// <remarks>
    /// Violating code conventions for species here so we can use Species as a namespace
    /// </remarks>
    public class _Species
    {
        public int Id { get; set; }
        public string Identifier { get; set; }
        public Color Color { get; set; }
        public Shape Shape { get; set; }
        public Habitat Habitat { get; set; }
        public GenderRate GenderRate { get; set; }
        public CaptureRate CaptureRate { get; set; }
        public int BaseHappiness { get; set; }
        public bool IsBaby { get; set; }
        public int HatchCounter { get; set; }
        /// <summary>
        /// Whether or not this pokemon has gender differences
        /// </summary>
        public bool IsDimorphic { get; set; }
        public GrowthRate GrowthRate { get; set; }
        public bool CanSwitchForms { get; set; }
        public int Order { get; set; }
        public IEnumerable<SpeciesName> Names { get; set; }
        public IEnumerable<SpeciesProse> Prose { get; set; }
        public IEnumerable<SpeciesFlavorSummary> FlavorSummaries { get; set; }
        public IEnumerable<SpeciesFlavorText> FlavorText { get; set; }
        /// <summary>
        /// Members of this species.
        /// </summary>
        public IEnumerable<Pokemon> Members { get; set; }
        /// <summary>
        /// The egg groups that this Species belongs to
        /// </summary>
        public IEnumerable<PokemonEggGroup> EggGroups { get; set; }
        public IEnumerable<PokemonPokedexNumber> PokedexNumbers { get; set; }
        public EvolutionChain EvolutionChain { get; set; }
        public _Species EvolvesFrom { get; set; }
        public Generation Generation { get; set; }
    }
}
