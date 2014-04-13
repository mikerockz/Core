using NXT.DAL.Entities.Languages;
namespace NXT.DAL.Entities.Generations
{
    /// <summary>
    /// The name of a generation.
    /// </summary>
    public class GenerationName
    {
        // pk on generation + language
        public Generation Generation { get; set; }
        public Language Language { get; set; }

        public string Name { get; set; }
    }
}
