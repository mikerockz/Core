using System.Collections.Generic;
namespace NXT.DAL.Entities
{
    /// <summary>
    /// The PokemonSpecies entity in Veekun.
    /// </summary>
    public class Species
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
        public bool IsDimorphic { get; set; }
        public GrowthRate GrowthRate { get; set; }
        public bool CanSwitchForms { get; set; }
        public int Order { get; set; }

        public IEnumerable<SpeciesNames> Names { get; set; }
        public IEnumerable<SpeciesProse> Prose { get; set; }
        public IEnumerable<FlavorSummaries> FlavorSummaries { get; set; }

        public EvolutionChain? EvolutionChain { get; set; }
        public Species? EvolvesFrom { get; set; }
        public Generation? Generation { get; set; }
    }
}
