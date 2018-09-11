using softaware.Holidays.Model;
using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("softaware.Holidays.Core.Tests")]

namespace softaware.Holidays
{
    /// <summary>
    /// Represents an object that knows about a specific easter sunday and enables holiday generation based on this date.
    /// </summary>
    public class GeneratorFunctions
    {
        private readonly DateTime easterSunday;
        
        internal GeneratorFunctions(DateTime easterSunday) : base() => this.easterSunday = easterSunday;

        /// <summary>
        /// Creates a holiday on a specific date in the same year as the easter sunday.
        /// </summary>
        /// <param name="name">The name of the holiday.</param>
        /// <param name="month">The month of the holiday's date.</param>
        /// <param name="day">The day of the holiday's date.</param>
        /// <param name="workingDay">Indicates if the day is a working day or not.</param>
        /// <returns>The holiday.</returns>
        public Holiday WithDate(string name, int month, int day, bool workingDay = false) => new Holiday { Name = name, Date = new DateTime(easterSunday.Year, month, day), WorkingDay = workingDay };

        /// <summary>
        /// Creates a holiday with n days before the easter sunday.
        /// </summary>
        /// <param name="name">The name of the holiday.</param>
        /// <param name="days">The amount of days before easter sunday.</param>
        /// <param name="workingDay">Indicates if the day is a working day or not.</param>
        /// <returns>The holiday.</returns>
        public Holiday BeforeEaster(string name, int days, bool workingDay = false) => new Holiday { Name = name, Date = easterSunday.Subtract(new TimeSpan(days, 0, 0, 0)), WorkingDay = workingDay };

        /// <summary>
        /// Creates a holiday with n days after the easter sunday.
        /// </summary>
        /// <param name="name">The name of the holiday.</param>
        /// <param name="days">The amount of days after easter sunday.</param>
        /// <param name="workingDay">Indicates if the day is a working day or not.</param>
        /// <returns>The holiday.</returns>
        public Holiday AfterEaster(string name, int days, bool workingDay = false) => new Holiday { Name = name, Date = easterSunday.Add(new TimeSpan(days, 0, 0, 0)), WorkingDay = workingDay };
    }
    
    /// <summary>
    /// Represents a generator that is capable of generating holidays.
    /// </summary>
    public class Generator
    {
        // the following algorithm is magic, invented by Gauß: https://de.wikipedia.org/wiki/Gau%C3%9Fsche_Osterformel
        internal DateTime EasterSunday(int year)
        {
            var k = year / 100;
            var m = 15 + (3 * k + 3) / 4 - (8 * k + 13) / 25;
            var s = 2 - (3 * k + 3) / 4;
            var a = year % 19;
            var d = (19 * a + m) % 30;
            var r = (d + a / 11) / 29;
            var og = 21 + d - r;
            var sz = 7 - (year + year / 4 + s) % 7;
            var oe = 7 - (og - sz) % 7;
            var os = og + oe;

            return new DateTime(year, 3 + os / 31, os % 31);
        }
        
        /// <summary>
        /// Returns <code>GeneratorFunctions</code> seeded with the calculated easter sunday for the given year.
        /// </summary>
        /// <param name="year">The year for which the holidays should be generated.</param>
        /// <returns><code>GeneratorFunctions</code> bound to the calculated easter sunday.</returns>
        public GeneratorFunctions Create(int year)
            => new GeneratorFunctions(EasterSunday(year));
    }
}
