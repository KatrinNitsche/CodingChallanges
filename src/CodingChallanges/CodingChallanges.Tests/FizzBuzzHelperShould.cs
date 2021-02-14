using Xunit;

namespace CodingChallanges.Tests
{
    public class FizzBuzzHelperShould
    {
        [Fact]
        public void ReturnAListOfStrings()
        {
            var sut = new FizzBuzzHelper();
            var result = sut.GetList();

            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }

        [Fact]
        public void ReturnAListOfCorrectStrings()
        {
            var sut = new FizzBuzzHelper();
            var result = sut.GetList();

            Assert.NotNull(result);
            Assert.NotEmpty(result);

            Assert.Equal("1", result[0]);
            Assert.Equal("2", result[1]);
            Assert.Equal("Fizz", result[2]);
            Assert.Equal("4", result[3]);
            Assert.Equal("Buzz", result[4]);
            Assert.Equal("Fizz", result[5]);
            Assert.Equal("7", result[6]);
            Assert.Equal("8", result[7]);
            Assert.Equal("Fizz", result[8]);
            Assert.Equal("Buzz", result[9]);
        }

        [Fact]
        public void ReturnAListOfCorrectStrings_2ndVersion()
        {
            var sut = new FizzBuzzHelper();
            var result = sut.GetList(FizzBuzzVersion.Verstion2, 100);

            Assert.NotNull(result);
            Assert.NotEmpty(result);

            Assert.Equal("1", result[0]);
            Assert.Equal("2", result[1]);
            Assert.Equal("Fizz", result[2]);
            Assert.Equal("4", result[3]);
            Assert.Equal("Buzz", result[4]);
            Assert.Equal("Fizz", result[5]);
            Assert.Equal("7", result[6]);
            Assert.Equal("8", result[7]);
            Assert.Equal("Fizz", result[8]);
            Assert.Equal("Buzz", result[9]);
        }

        [Fact]
        public void ReturnAListOfCorrectStrings_RuleVersion()
        {
            var sut = new FizzBuzzHelper();
            var result = sut.GetList(FizzBuzzVersion.UsingRules, 100);

            Assert.NotNull(result);
            Assert.NotEmpty(result);

            Assert.Equal("1", result[0]);
            Assert.Equal("2", result[1]);
            Assert.Equal("Fizz", result[2]);
            Assert.Equal("4", result[3]);
            Assert.Equal("Buzz", result[4]);
            Assert.Equal("Fizz", result[5]);
            Assert.Equal("7", result[6]);
            Assert.Equal("8", result[7]);
            Assert.Equal("Fizz", result[8]);
            Assert.Equal("Buzz", result[9]);
        }
    }
}
