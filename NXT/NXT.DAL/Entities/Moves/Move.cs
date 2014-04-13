using System.Collections.Generic;
namespace NXT.DAL.Entities.Moves
{
    public class Move
    {

        public int Id { get; set; }
        public string Identifier { get; set; }
         
        public int Power { get; set; }
        public int PP { get; set; }
        public int Accuracy { get; set; }
        public int Priority { get; set; }
        public int EffectChance { get; set; }

        //foreign
        public Generation Generation { get; set; }
        public MoveMetaCategory MetaCategory { get; set; }
        public IEnumerable<MoveTarget> Targets { get; set; }
        public IEnumerable<MoveEffect> Effects { get; set; }
        public IEnumerable<MoveBattleStyle> BattleStyles { get; set; }
        public IEnumerable<MoveMetaAilment> MetaAliments { get; set; }
    }
}