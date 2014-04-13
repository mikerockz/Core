using NXT.DAL.Entities.Names;
namespace NXT.DAL.Entities.Languages
{
    /// <summary>
    /// The name of a language.
    /// </summary>
    public class LanguageName : AbstractName<Language>
    {
        // pk on NamedLanguage and Language
        /// <summary>
        /// The language that is being named by this LanguageName instance
        /// </summary>
        public Language NamedLanguage { get; set; }
    }
}
