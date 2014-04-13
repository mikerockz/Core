using NXT.DAL.Entities.Languages;
namespace NXT.DAL.Entities.Moves
{
    public class MoveDamageClassProse
    {
        public MoveDamageClass MoveDamageClass { get; set; }
        public Language Language { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
