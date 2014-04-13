using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NXT.DAL.Entities.Moves
{
    class MoveChangelog
    {
        Move Move { get; set; }
        VersionGroup VersionGroup { get; set; }
        Type Type { get; set; }
        MoveEffect MoveEffect { get; set; }
    }
}
