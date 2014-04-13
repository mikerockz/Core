using NXT.DAL.Entities.Languages;
namespace NXT.DAL.Entities.Habitats
{
    /// <summary>
    /// The name of a Habitat.
    /// </summary>
    public class HabitatName
    {
        // pk on habitat + language
        public Habitat Habitat { get; set; }
        public Language Language { get; set; }
        public string Name { get; set; }
    }
}
