using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NXT.DAL.Entities.Nature;
namespace NXT.DAL.Entities.Moves
{
    public class Nature_Battle_Style_Preference
    {
        public Nature.Nature Nature { get; set; }
        public MoveBattleStyle MovementBattleStyle { get; set; }
        public int LowHpPreference { get; set; }
        public int HighHpPreference { get; set; }
    }
}
