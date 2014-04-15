using NXT.DAL.Entities.Pokemons;
using System.Collections.Generic;
namespace NXT.DAL.Entities.Moves
{
    public class MoveDamageClass
    {
        public int Id { get; set; } 
        public string Identifier { get; set; }
        public ICollection<Move> Moves { get; set; }
        public ICollection<Stat> Stats { get; set; }
        public ICollection<Type> Types { get; set; }
        public ICollection<MoveDamageClassProse> MoveDamageClassProses { get; set; }

    }
}
