using Xunit;

namespace CodingChallanges.Tests
{
    public class NumberHelperShould
    {
        [Theory]
        [InlineData(1, true)]
        [InlineData(153, true)]      
        [InlineData(15, false)]
        [InlineData(160, false)]
        [InlineData(5972, false)]
        public void ReturnIfNumberIsArmstrongNumber(int number, bool result)
        {
            var checkResult = NumberHelper.IsArmstrong(number);
            Assert.Equal(result, checkResult);
        }
    }
}
