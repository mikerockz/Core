using System.Collections.Generic;
namespace NXT.DAL.Entities.Habitats
{
    /// <summary>
    /// A habitat that a Pokemon prefers to live in.
    /// </summary>
    public class Habitat
    {
        public int Id { get; set; }
        public string Identifier { get; set; }
        public IEnumerable<HabitatName> Names { get; set; }
    }
}
