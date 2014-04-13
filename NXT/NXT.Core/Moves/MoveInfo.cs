namespace NXT.Core.Moves
{
    public class MoveInfo
    {
        public int Id { get; set; }
        public string Identifier { get; set; }

        public int Power { get; set; }
        public int PP { get; set; }
        public int Accuracy { get; set; }
        public int Priority { get; set; }
        public int EffectChance { get; set; }
    }
}
