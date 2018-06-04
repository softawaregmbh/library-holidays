using System;
using Xunit;

namespace softaware.Holidays.Core.Tests
{
    public class Tests
    {
        [Fact]
        public void EasterSunday2018()
        {
            Assert.Equal(
                new Generator().EasterSundayGregorian(2018),
                new DateTime(2018, 4, 1));
        }
        
        [Fact]
        public void EasterSunday2019()
        {
            Assert.Equal(
                new Generator().EasterSundayGregorian(2019),
                new DateTime(2019, 4, 21));
        }
    }
}
