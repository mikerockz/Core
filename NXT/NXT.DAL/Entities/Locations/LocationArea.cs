using NXT.DAL.Entities.Encounters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NXT.DAL.Entities.Locations
{
    public class LocationArea
    {
        public int Id { get; set; }
        public string Identifier { get; set; }
        public Location Location { get; set; }
        public int GameIndex { get; set; }

        public IEnumerable<LocationAreaEncounterRate> LocationAreaEncounterRates { get; set; }
        public IEnumerable<LocationAreaProse> LocationAreaProses { get; set; }
        public IEnumerable<Encounter> LocationAreaEncounters { get; set; }
    }
}
