using NXT.DAL.Entities.Pokemons;
namespace NXT.DAL.Entities.Moves
{
    public class MoveChangelog
    {
        public Move Move { get; set; }
        public VersionGroup VersionGroup { get; set; }
        public Type Type { get; set; }
        public MoveEffect MoveEffect { get; set; }
    }
}
