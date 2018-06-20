using softaware.Holidays.Model;
using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("softaware.Holidays.Core.Tests")]

namespace softaware.Holidays
{
    /// <summary>
    /// Generator functions
    /// </summary>
    public class GeneratorFunctions
    {
        private readonly DateTime easterSunday;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="easterSunday"></param>
        public GeneratorFunctions(DateTime easterSunday) : base() => this.easterSunday = easterSunday;

        /// <summary>
        /// With date
        /// </summary>
        /// <param name="name"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public Holiday WithDate(string name, int month, int day) => new Holiday { Name = name, Date = new DateTime(easterSunday.Year, month, day) };

        /// <summary>
        /// Before easter
        /// </summary>
        /// <param name="name"></param>
        /// <param name="days"></param>
        /// <returns></returns>
        public Holiday BeforeEaster(string name, int days) => new Holiday { Name = name, Date = easterSunday.Subtract(new TimeSpan(days, 0, 0, 0)) };

        /// <summary>
        /// After easter
        /// </summary>
        /// <param name="name"></param>
        /// <param name="days"></param>
        /// <returns></returns>
        public Holiday AfterEaster(string name, int days) => new Holiday { Name = name, Date = easterSunday.Add(new TimeSpan(days, 0, 0, 0)) };
    }

    /// <summary>
    /// Generator
    /// </summary>
    public class Generator
    {
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
        /// Create method
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public GeneratorFunctions Create(int year)
            => new GeneratorFunctions(EasterSunday(year));
    }
}
