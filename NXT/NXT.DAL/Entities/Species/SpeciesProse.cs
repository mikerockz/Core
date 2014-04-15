using NXT.DAL.Entities.Languages;
namespace NXT.DAL.Entities.Species
{
    /// <summary>
    /// I'm not entirely sure where the prose is displayed but some of it is useful.
    /// Recommend you check out the table for more info. It seems to only really
    /// describe information about different forms, so perhaps it's used to introduce
    /// information about forms to players.
    /// </summary>
    public class SpeciesProse
    {
        // pk on species + language
        public _Species Species { get; set; }
        public Language Language { get; set; }
        public string FormDescription { get; set; }
    }
}
