using System;
using Xunit;
using softaware.Holidays.Extensions;

namespace softaware.Holidays.Core.Tests
{
    public class Tests
    {
        [Fact]
        public void EasterSunday2018()
        {
            Assert.Equal(
                new Generator().EasterSunday(2018),
                1.January(2018));
        }
        
        [Fact]
        public void EasterSunday2019()
        {
            Assert.Equal(
                new Generator().EasterSunday(2019),
                new DateTime(2019, 4, 21));
        }
    }
}
