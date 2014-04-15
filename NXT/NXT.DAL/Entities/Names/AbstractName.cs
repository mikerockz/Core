using NXT.DAL.Entities.Languages;
namespace NXT.DAL.Entities.Names
{
    /// <summary>
    /// To prevent us from writing the same goddamn thing over and over
    /// This is an abstract name class, XName classes inherit from this.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AbstractName<T> where T : class
    {
        public Language Language { get; set; }
        public T Owner { get; set; }
        public string Name { get; set; }

        public int OwnerId { get; set; }
        public int LanguageId { get; set; }
    }
}
