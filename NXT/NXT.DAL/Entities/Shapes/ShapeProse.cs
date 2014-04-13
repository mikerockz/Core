using NXT.DAL.Entities.Languages;
namespace NXT.DAL.Entities.Shapes
{
    /// <summary>
    /// Prose information for a Shape. Basically gives you a english-legible description of what the shape looks like.
    /// </summary>
    public class ShapeProse
    {
        // pk on shape + language
        public Shape Shape { get; set; }
        public Language Language { get; set; }

        public string Name { get; set; }
        /// <summary>
        /// Yes, this is the actual column name. As far as I can see,
        /// it basically uses more advanced English names. For example,
        /// the Armor shape is described as Chitinous.
        /// </summary>
        public string AwesomeName { get; set; }
    }
}
