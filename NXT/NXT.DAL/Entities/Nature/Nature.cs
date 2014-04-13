using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NXT.DAL.Entities.Nature
{
    class Nature
    {
        public int Id { get; set; }
        public string Identifier { get; set; }
        public Stat DecreasedStat { get; set; }
        public Stat IncreasedStat { get; set; }
    }
}
