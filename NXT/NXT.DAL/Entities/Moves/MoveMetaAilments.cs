using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NXT.DAL.Entities.Moves
{
    class MoveMetaAilments
    {
        public int Id { get; set; }  
        public string Identifier { get; set; }

        public MoveMetaAilmentNames MetaAilments { get; set; }
       

    }
}
