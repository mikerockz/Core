using NXT.DAL.Entities.Names;
namespace NXT.DAL.Entities.Shapes
{
    /// <summary>
    /// Prose information for a Shape. Basically gives you a english-legible description of what the shape looks like.
    /// </summary>
    public class ShapeProse : AbstractName<Shape>
    {
        /// <summary>
        /// Yes, this is the actual column name. As far as I can see,
        /// it basically uses more advanced English names. For example,
        /// the Armor shape is described as Chitinous.
        /// </summary>
        public string AwesomeName { get; set; }
    }
}
