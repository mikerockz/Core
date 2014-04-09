using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NXT.DAL.Entities.Pokemons
{
    public class PokemonStat
    {
        public int Effort { get; set; }
        public int Base { get; set; }
        public Pokemon Pokemon { get; set; }
        public Stat Stat { get; set; }
    }
}
