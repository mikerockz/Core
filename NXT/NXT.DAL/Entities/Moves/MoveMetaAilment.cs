using System.Collections.Generic;
namespace NXT.DAL.Entities.Moves
{
    public class MoveMetaAilment
    {
        public int Id { get; set; }  
        public string Identifier { get; set; }

        public ICollection<MoveMetaAilmentName> Names { get; set; }
    }
}
