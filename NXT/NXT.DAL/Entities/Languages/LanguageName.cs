namespace NXT.DAL.Entities.Languages
{
    /// <summary>
    /// The name of a language.
    /// </summary>
    public class LanguageName
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // There's a composite primary key on LanguageId and LocalLanguageId
        /// <summary>
        /// The language that is being named by this LanguageName instance
        /// </summary>
        public Language NamedLanguage { get; set; }
        /// <summary>
        /// The language that the name is in.
        /// </summary>
        public Language LocalLanguage { get; set; }
    }
}
