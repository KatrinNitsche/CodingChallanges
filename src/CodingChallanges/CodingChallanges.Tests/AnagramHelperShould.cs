using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CodingChallanges.Tests
{
    public class AnagramHelperShould
    {
        [Fact]
        public void ReturnPositiv()
        {
            var sut = new AnagramHelper();
            var result = sut.Compare("Test", "estT");

            Assert.True(result);
        }

        [Fact]
        public void ReturnNegative()
        {
            var sut = new AnagramHelper();
            var result = sut.Compare("Test", "NotEqual");

            Assert.False(result);
        }
    }
}
