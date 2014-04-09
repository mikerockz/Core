using System.Collections.Generic;
namespace NXT.DAL.Entities
{
    /// <summary>
    /// The Pokemon entity in Veekun.
    /// </summary>
    public class Pokemon
    {
        public string Identifier { get; set; }

        public float Height { get; set; }
        public float Weight { get; set; }

        public int BaseExperience { get; set; }
        public int Order { get; set; }

        public Species Species { get; set; }
        public IEnumerable<Stat> Stats { get; set; }
        public IEnumerable<BaseStat> BaseStats { get; set; }

        public int Id { get; set; }

        public bool IsDefault { get; set; }
    }
}
