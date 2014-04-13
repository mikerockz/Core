using System.Collections.Generic;
namespace NXT.DAL.Entities.Languages
{
    /// <summary>
    /// Denotes a Language from the Veekun library.
    /// </summary>
    /// <remarks>
    /// PokemonNXT only supports English currently (ID = 9)
    /// </remarks>
    public class Language
    {
        public int Id { get; set; }
        public string Identifier { get; set; }
        /// <summary>
        /// A string denoting an ISO639 representation of the language
        /// </summary>
        public string Iso639 { get; set; }
        /// <summary>
        /// A string denoting an ISO3166 representation of the language
        /// </summary>
        public string Iso3166 { get; set; }
        /// <summary>
        /// Whether or not the language is officially supported (?)
        /// </summary>
        public bool Official { get; set; }
        /// <summary>
        /// The names of this language in other languages.
        /// </summary>
        public IEnumerable<LanguageName> Names { get; set; }
    }
}
