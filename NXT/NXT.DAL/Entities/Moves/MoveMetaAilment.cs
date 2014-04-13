using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NXT.DAL.Entities.Moves
{
    class MoveMetaAilment
    {
        public int Id { get; set; }  
        public string Identifier { get; set; }

        public MoveMetaAilmentName MetaAilments { get; set; }
       

    }
}
