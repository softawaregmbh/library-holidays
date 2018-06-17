using System;
using System.Collections.Generic;
using System.Text;

namespace softaware.Holidays.Extensions
{
    /// <summary>
    /// Contains extension methods for an easer creation of <see cref="DateTime"/>s.
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Constructs a DateTime using human readable code like <c>1.January(1970)</c>, which is equivalent to <code>new DateTime(1970, 1, 1)</code>.
        /// </summary>
        /// <param name="day">Day</param>
        /// <param name="year">Year</param>
        /// <returns></returns>
        public static DateTime January(this int day, int year) =>
            new DateTime(year, 1, day);
    }
}
