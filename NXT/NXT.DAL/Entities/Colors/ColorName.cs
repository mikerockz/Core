using NXT.DAL.Entities.Languages;
namespace NXT.DAL.Entities.Colors
{
    /// <summary>
    /// The name of a Color.
    /// </summary>
    public class ColorName
    {
        // pk on Color and Language
        public Color Color { get; set; }
        public Language Language { get; set; }
        public string Name { get; set; }
    }
}
