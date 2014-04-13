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
        public ICollection<LocationArea> LocationAreas { get; set; }
        public ICollection<LocationGameIndex> LocationGameIndices { get; set; }
        public ICollection<LocationName> LocationNames { get; set; }
        public ICollection<PokemonEvolution> PokemonEvolutions { get; set; }
    }
}
