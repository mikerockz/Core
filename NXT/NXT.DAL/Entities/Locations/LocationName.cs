using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NXT.DAL.Entities.Locations
{
    public class LocationName
    {
        public Location Location { get; set; }
        public int LocalLanguageId { get; set; }
        public string Name { get; set; }
    }
}
