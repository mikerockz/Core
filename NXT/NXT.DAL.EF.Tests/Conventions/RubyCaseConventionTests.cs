using NXT.DAL.EF.Conventions;
using Xunit;
namespace NXT.DAL.EF.Tests.Conventions
{
    /// <summary>
    /// Tests to ensure the functionality of the RubyCaseConvention
    /// </summary>
    public class RubyCaseConventionTests
    {
        [Fact]
        public void Conventionalize_CamelCaseStringWithMultipleWords_RubyCaseStringWithSameNumberOfWords()
        {
            var inputString = "ANameWithMultipleWords";
            var expectedResult = "a_name_with_multiple_words";
            var convention = new RubyCaseConvention();

            var result = convention.Conventionalize(inputString);

            Assert.Equal(expectedResult, result);
        }
    }
}
