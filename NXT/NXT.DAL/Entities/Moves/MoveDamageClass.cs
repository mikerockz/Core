using NXT.DAL.Entities.Pokemons;
using System.Collections.Generic;
namespace NXT.DAL.Entities.Moves
{
    public class MoveDamageClass
    {
        public int Id { get; set; } 
        public string Identifier { get; set; }
        public IEnumerable<Move> Moves { get; set; }
        public IEnumerable<Stat> Stats { get; set; }
        public IEnumerable<Type> Types { get; set; }
        public IEnumerable<MoveDamageClassProse> MoveDamageClassProses { get; set; }

    }
}
