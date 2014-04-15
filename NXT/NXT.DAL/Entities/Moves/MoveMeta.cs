namespace NXT.DAL.Entities.Moves
{
    public class MoveMeta 
    {
        public Move Move { get; set; }

        public MoveMetaCategory MoveMetaCategory { get; set; }
        public MoveMetaAilment MoveMetaAilment { get; set; }
        
        
        //Minimum and maximum hits/turns taken for move.
        public int MinHits { get; set; }
        public int MaxHits { get; set; }
        public int MinTurns { get; set; }
        public int MaxTurns { get; set; }

        public int Recoil { get; set; }
        public int Healing { get; set; }
        public int CritRate { get; set; }
        public int AilmentChance { get; set; }
        public int FlinchChance { get; set; }
        public int StatChance { get; set; }
    }
}
