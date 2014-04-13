using System.Collections.Generic;

namespace NXT.DAL.Entities.Moves
{
    public class MoveEffect
    { 
        public int Id { get; set; }
        public IEnumerable<MoveChangelog> MoveChangelogs { get; set; }
        public IEnumerable<Move> Moves { get; set; }
        public IEnumerable<MoveEffectProse> MoveEffectProses { get; set; }
    }
}
