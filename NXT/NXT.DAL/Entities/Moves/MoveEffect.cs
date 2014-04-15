using System.Collections.Generic;

namespace NXT.DAL.Entities.Moves
{
    public class MoveEffect
    { 
        public int Id { get; set; }
        public ICollection<MoveChangelog> MoveChangelogs { get; set; }
        public ICollection<Move> Moves { get; set; }
        public ICollection<MoveEffectProse> MoveEffectProses { get; set; }
    }
}
