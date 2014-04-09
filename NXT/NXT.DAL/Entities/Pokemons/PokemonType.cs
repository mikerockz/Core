namespace NXT.DAL.Entities.Pokemons
{
    public class PokemonType
    {
        // Primary key = Pokemon + Slot
        public Pokemon Pokemon { get; set; }
        public Type Type { get; set; }
        public int Slot { get; set; }
    }
}
