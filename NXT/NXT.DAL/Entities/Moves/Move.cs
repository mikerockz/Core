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
        public MoveMetaCategories MetaCategory { get; set; }
        public IEnumerable<MoveTargets> Targets { get; set; }
        public IEnumerable<MoveEffects> Effects { get; set; }
        public IEnumerable<MoveBattleStyles> BattleStyles { get; set; }
        public IEnumerable<MoveMetaAilments> MetaAliments { get; set; }
    }
}