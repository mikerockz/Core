using NXT.DAL.Entities.Items;
namespace NXT.DAL.Entities.Pokemons
{
    public class PokemonItem
    {
        // Primary key = Pokemon + version + Item
        public Pokemon Pokemon { get; set; }
        public GameVersion Version { get; set; }
        public Item Item { get; set; }

        public int Rarity { get; set; }
    }
}
