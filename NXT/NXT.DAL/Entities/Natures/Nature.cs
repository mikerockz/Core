namespace NXT.DAL.Entities.Natures
{
    public class Nature
    {
        public int Id { get; set; }
        public string Identifier { get; set; }
        public Stat DecreasedStat { get; set; }
        public Stat IncreasedStat { get; set; }
    }
}
