using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NXT.DAL.Entities.Pokemons
{
    public class PokemonGameIndice
    {
        public Pokemon Pokemon { get; set; }
        public GameVersion Version { get; set; }
        public int Indice { get; set; }
    }
}
