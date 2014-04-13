using System.Collections.Generic;
namespace NXT.DAL.Entities.Moves
{
    public class MoveMetaAilment
    {
        public int Id { get; set; }  
        public string Identifier { get; set; }

        public IEnumerable<MoveMetaAilmentName> Names { get; set; }
    }
}
