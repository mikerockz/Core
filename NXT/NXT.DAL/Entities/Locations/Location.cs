using NXT.DAL.Entities.Regions;
using NXT.DAL.Entities.Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NXT.DAL.Entities.Locations
{
    public class Location
    {
        public int Id { get; set; }
        public string Identifier { get; set; }
        public Region Region { get; set; }
        public IEnumerable<LocationArea> LocationAreas { get; set; }
        public IEnumerable<LocationGameIndex> LocationGameIndices { get; set; }
        public IEnumerable<LocationName> LocationNames { get; set; }
        public IEnumerable<PokemonEvolution> PokemonEvolutions { get; set; }
    }
}
