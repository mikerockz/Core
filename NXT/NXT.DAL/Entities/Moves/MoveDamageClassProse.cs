using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NXT.DAL.Entities.Moves
{
    public class MoveDamageClassProse
    {
        public MoveDamageClass MoveDamageClass { get; set; }
        public int LocalLanguageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
