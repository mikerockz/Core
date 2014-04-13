using NXT.DAL.Entities.Languages;
namespace NXT.DAL.Entities
{
    /// <summary>
    /// Extension methods for entities
    /// </summary>
    public static class EntityExtensions
    {
        /// <summary>
        /// Indicates whether or not this Language instance is English
        /// </summary>
        /// <param name="language"></param>
        /// <returns></returns>
        public static bool IsEnglish(this Language language)
        {
            return language.Id == 9;
        }
    }
}
