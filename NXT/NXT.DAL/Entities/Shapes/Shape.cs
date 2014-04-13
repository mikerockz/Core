using System.Collections.Generic;
namespace NXT.DAL.Entities.Shapes
{
    /// <summary>
    /// The shape of a Pokemon.
    /// </summary>
    public class Shape
    {
        public int Id { get; set; }
        public string Identifier { get; set; }
        public IEnumerable<ShapeProse> Prose { get; set; }
    }
}
