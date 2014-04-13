using NXT.DAL.Entities.Encounters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NXT.DAL.Entities.Locations
{
    public class LocationAreaEncounterRate
    {
        public LocationArea LocationArea { get; set; }
        public EncounterMethod EncounterMethod { get; set; }
        public Version Version { get; set; }
        public int Rate { get; set; }
    }
}
