using Xunit;

namespace CodingChallanges.Tests
{
    public class StringHelperShould
    {
        [Theory]
        [InlineData("Test", "tseT")]
        [InlineData("Reverse", "esreveR")]
        public void ReturnReversedString(string text, string reversedText)
        {
            var sut = new StringHelper();
            var result = sut.Reverse(text);

            Assert.Equal(reversedText, result);
        }
    }
}
