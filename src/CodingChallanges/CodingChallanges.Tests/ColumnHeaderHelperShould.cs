using System;
using Xunit;

namespace CodingChallanges.Tests
{
    public class ColumnHeaderHelperShould
    {
        [Fact]
        public void ReturnAValidHeaderString()
        {
            var sut = new ColumnHeaderHelper();
            var headerString = sut.HeaderFor(1);

            Assert.Equal("A", headerString);
        }

        [Fact]
        public void ReturnAValidHeaderString_End()
        {
            var sut = new ColumnHeaderHelper();
            var headerString = sut.HeaderFor(26);

            Assert.Equal("Z", headerString);
        }

        [Fact]
        public void ReturnAValidHeaderString_DoubleLength()
        {
            var sut = new ColumnHeaderHelper();
            var headerString = sut.HeaderFor(27);

            Assert.Equal("AA", headerString);
        }

        [Fact]
        public void ReturnAValidHeaderString_DoubleLength_End()
        {
            var sut = new ColumnHeaderHelper();
            var headerString = sut.HeaderFor(52);

            Assert.Equal("AZ", headerString);
        }

        [Fact]
        public void ReturnAnEmptyStringForInvalidColumn()
        {
            var sut = new ColumnHeaderHelper();
            var headerString = sut.HeaderFor(-1);

            Assert.Equal(string.Empty, headerString);
        }
    }
}
