using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NXT.DAL.Entities.Moves
{
    class MoveBattleStyle
    {
        public int Id { get; set; }  
        public string Identifier { get; set; }

        public IEnumerable<MoveBattleStyleProse> BattleStyleProse { get; set; }
        public IEnumerable<Nature_Battle_Style_Preference> NatureBattleStylePreference { get; set; }
    }
}
