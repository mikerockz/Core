using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NXT.DAL.Entities.Moves
{
    public class MoveEffectProse
    {
        public MoveEffect MoveEffect { get; set; }
        public int LocalLanguageId { get; set; }
        public string ShortEffect { get; set; }
        public string Effect { get; set; }
    }
}
