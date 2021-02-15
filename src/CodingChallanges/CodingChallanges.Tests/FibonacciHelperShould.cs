using System.Collections.Generic;
using Xunit;

namespace CodingChallanges.Tests
{
    public class FibonacciHelperShould
    {
        // 0	1	1	2	3	5	8	13	21	34	55	89	144	233	377	610	987	1597	2584	4181	6765
        [Theory]
        [InlineData(3, 2)]
        [InlineData(9, 34)]
        [InlineData(20, 6765)]
        public void ReturnTheNthNumber(int number, int expectedValue)
        {
            var sut = new FibonacciHelper();
            var result = sut.GetNumber(number);

            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData(4, new int[] { 0, 1, 1, 2 })]
        [InlineData(10, new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 })]
        public void ReturnTheSequence(int number, int[] expectedSequence)
        {
            var sut = new FibonacciHelper();
            var result = sut.GetSequenceUpTo(number);

            Assert.NotNull(result);
            Assert.Equal(expectedSequence, result);
        }
    }
}
