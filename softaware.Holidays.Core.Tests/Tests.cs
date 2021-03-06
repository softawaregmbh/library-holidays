using System;
using FsCheck;
using FsCheck.Xunit;
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

        [Property]
        public void ShouldBeSunday(PositiveInt year)
        {
            Assert.Equal(
                DayOfWeek.Sunday,
                new Generator().EasterSunday(year.Get).DayOfWeek);
        }
    }
}
