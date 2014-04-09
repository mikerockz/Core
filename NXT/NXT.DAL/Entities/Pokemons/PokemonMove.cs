using NXT.DAL.Entities.Moves;
namespace NXT.DAL.Entities.Pokemons
{
    public class PokemonMove
    {
        public Pokemon Pokemon { get; set; }
        public Move Move { get; set; }
        public VersionGroup VersionGroup { get; set; }
        public PokemonMoveMethod MoveMethod { get; set; }
        public int Order { get; set; }
        public int Level { get; set; }
    }
}
