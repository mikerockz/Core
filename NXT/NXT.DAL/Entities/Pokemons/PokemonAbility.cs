using NXT.DAL.Entities.Abilities;
namespace NXT.DAL.Entities.Pokemons
{
    /// <summary>
    /// The abilities a Pokemon can learn.
    /// </summary>
    public class PokemonAbility
    {
        // This has a compound primary key
        // Which is Pokemon + Slot
        
        public Ability Ability { get; set; }
        public Pokemon Pokemon { get; set; }
        public int Slot { get; set; }
        public bool IsHidden { get; set; }
    }
}
