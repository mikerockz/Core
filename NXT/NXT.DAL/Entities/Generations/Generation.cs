using System.Collections.Generic;
namespace NXT.DAL.Entities.Generations
{
    public class Generation
    {
        public int Id { get; set; }
        public Region Region { get; set; } 
        public string Identifier {get;set;}
        public IEnumerable<GenerationName> Names { get; set; }
    }
}
