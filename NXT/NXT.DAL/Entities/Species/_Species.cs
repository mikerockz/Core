using NXT.DAL.Entities.Colors;
using NXT.DAL.Entities.Shapes;
using NXT.DAL.Entities.Pokemons;
using System;
using System.Collections.Generic;
using NXT.DAL.Entities.Habitats;
using NXT.DAL.Entities.Growth;
using NXT.DAL.Entities.Generations;
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
        /// <summary>
        /// Apparently, this is a number and not a table. Might end up being an enum.
        /// </summary>
        public int GenderRate { get; set; }
        /// <summary>
        /// Another non-table. I think we will want some way of overriding this, because I don't think
        /// we want to rely on the veekun implementation.
        /// </summary>
        public int CaptureRate { get; set; }
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
        public ICollection<SpeciesName> Names { get; set; }
        public ICollection<SpeciesProse> Prose { get; set; }
        /// <summary>
        /// The flavour summaries for a Pokemon.
        /// Marked as obsolete due to only 1 entry of this in Veekun.
        /// </summary>
        [Obsolete]
        public ICollection<SpeciesFlavorSummary> FlavorSummaries { get; set; }
        public ICollection<SpeciesFlavorText> FlavorText { get; set; }
        /// <summary>
        /// Members of this species.
        /// </summary>
        public ICollection<Pokemon> Members { get; set; }
        /// <summary>
        /// The egg groups that this Species belongs to
        /// </summary>
        public ICollection<PokemonEggGroup> EggGroups { get; set; }
        public ICollection<PokemonPokedexNumber> PokedexNumbers { get; set; }
        public EvolutionChain EvolutionChain { get; set; }
        public _Species EvolvesFrom { get; set; }
        public Generation Generation { get; set; }
    }
}
