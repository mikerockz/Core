
using System.Collections.Generic;
namespace NXT.DAL.Entities.Pokemons
{
    public class PokemonForm
    {
        public string Identifier { get; set; }
        /// <summary>
        /// An identifier that indicates what form this is
        /// </summary>
        /// <remarks>
        /// This is different from Identifier, which has the format pokemonname-formname.
        /// </remarks>
        public string FormIdentifier { get; set; }
        public bool IsDefault { get; set; }
        public bool IsBattleOnly { get; set; }
        public bool IsMegaEvolution { get; set; }
        /// <summary>
        /// The order of the form, relative to the Pokemon
        /// </summary>
        public int FormOrder { get; set; }
        public int Order { get; set; }


        public ICollection<PokemonFormName> FormNames { get; set; }
        public ICollection<PokemonFormGeneration> Generations { get; set; }
        public Pokemon Pokemon { get; set; }
        public VersionGroup IntroducedIn { get; set; }
    }
}
