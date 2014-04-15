
﻿using System.Collections.Generic;
﻿using NXT.DAL.Entities.Regions;


namespace NXT.DAL.Entities.Generations
{
    public class Generation
    {
        public int Id { get; set; }
        public Region Region { get; set; } 
        public string Identifier {get;set;}
        public ICollection<GenerationName> Names { get; set; }
    }
}
