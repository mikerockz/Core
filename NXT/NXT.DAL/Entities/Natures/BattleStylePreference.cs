using NXT.DAL.Entities.Moves;
namespace NXT.DAL.Entities.Natures
{
    public class BattleStylePreference
    {
        public Nature Nature { get; set; }
        public MoveBattleStyle MovementBattleStyle { get; set; }
        public int LowHpPreference { get; set; }
        public int HighHpPreference { get; set; }
    }
}
