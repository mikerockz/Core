using System.Collections.Generic;
namespace NXT.DAL.Entities.Colors
{
    public class Color
    {
        public int Id { get; set; }
        public string Identifier { get; set; }
        public IEnumerable<ColorName> Names { get; set; }
    }
}
