using NXT.DAL.Entities.Natures;
using System.Collections.Generic;

namespace NXT.DAL.Entities.Moves
{
    public class MoveBattleStyle
    {
        public int Id { get; set; }  
        public string Identifier { get; set; }

        public IEnumerable<MoveBattleStyleProse> BattleStyleProses { get; set; }


        // clockworks 13/04/2014
        // this doesn't go here - nature has a requirement on move, not the other way around
        // not something you could tell by looking at the database but when you think about it
        // it makes sense - why would a move battle style need to know about pokemon nature? 
        // however natures have preferred battle styles
        // public IEnumerable<BattleStylePreference> NatureBattleStylePreferences { get; set; }
    }
}
