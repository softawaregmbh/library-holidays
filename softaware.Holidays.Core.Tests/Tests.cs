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
                new DateTime(2018, 4, 1),
                new Generator().EasterSunday(2018));
        }
        
        [Fact]
        public void EasterSunday2019()
        {
            Assert.Equal(
                new DateTime(2019, 4, 21),
                new Generator().EasterSunday(2019));
        }
    }
}
