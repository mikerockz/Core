using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text;
using System.Text.RegularExpressions;
namespace NXT.DAL.EF.Conventions
{
    /// <summary>
    /// An entity framework convention that forces multiple words in a property name,
    /// indicated by CamelCase, to be underscored, and lower-cased
    /// </summary>
    public class RubyCaseConvention : Convention
    {
        private readonly Regex _matcher = new Regex("([A-Z])");

        public RubyCaseConvention()
        {
            Properties()
                .Configure(p => p.HasColumnName(Conventionalize(p.ClrPropertyInfo.Name)));
        }

        public string Conventionalize(string inputName)
        {
            // Convert a CamelCase name into ruby_case
            if (_matcher.IsMatch(inputName))
            {
                string strReplace = @"_$1";
                var replaced = _matcher.Replace(inputName, strReplace);
                // Remove the first character, which will be an underscore.
                return replaced.Remove(0, 1)
                               .ToLower();
            }
            return inputName.ToLower();
        }
    }
}
