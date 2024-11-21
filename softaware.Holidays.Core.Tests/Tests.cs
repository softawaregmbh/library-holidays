using System;
using FsCheck;
using FsCheck.Xunit;
using Xunit;

namespace softaware.Holidays.Core.Tests
{
    public class Tests
    {
        [Fact]
        public void EasterSunday2013()
        {
            Assert.Equal(
                new DateTime(2013, 3, 31),
                new Generator().EasterSunday(2013));
        }

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

        [Fact]
        public void MothersDay2013()
        {
            Assert.Equal(
                new DateTime(2013, 5, 12),
                new Generator().Create(2013).NthDayInMonth("Muttertag", 2, DayOfWeek.Sunday, 5).Date);
        }

        [Fact]
        public void MothersDay2018()
        {
            Assert.Equal(
                new DateTime(2018, 5, 13),
                new Generator().Create(2018).NthDayInMonth("Muttertag", 2, DayOfWeek.Sunday, 5).Date);
        }

        [Fact]
        public void MothersDay2019()
        {
            Assert.Equal(
                new DateTime(2019, 5, 12),
                new Generator().Create(2019).NthDayInMonth("Muttertag", 2, DayOfWeek.Sunday, 5).Date);
        }
    }
}
