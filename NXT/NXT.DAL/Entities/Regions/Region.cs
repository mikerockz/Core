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
        ICollection<Generation> MainGeneration { get; set; }
        ICollection<RegionName> RegionNames { get; set; }
        ICollection<Location> RegionLocations { get; set; }
        ICollection<Pokedex> PokeDexes { get; set; }
     }
}
