using NXT.DAL.Entities.Locations;
using NXT.DAL.Entities.Generations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NXT.DAL.Entities.Pokedexes;

namespace NXT.DAL.Entities.Regions
{
    public class Region
    {
        public int Id { get; set; }
        public string Identifier { get; set; }
        IEnumerable<Generation> MainGeneration { get; set; }
        IEnumerable<RegionName> RegionNames { get; set; }
        IEnumerable<Location> RegionLocations { get; set; }
        IEnumerable<Pokedex> PokeDexes { get; set; }
     }
}
