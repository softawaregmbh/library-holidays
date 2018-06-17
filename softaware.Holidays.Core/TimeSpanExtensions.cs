using System;
using System.Collections.Generic;
using System.Text;

namespace softaware.Holidays.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public static class TimeSpanExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="one"></param>
        /// <returns></returns>
        public static TimeSpan Day(this int one) =>
            one == 1 ? new TimeSpan(one, 0, 0, 0) : throw new Exception("You jerk, i even called the param `one`... :P");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="days"></param>
        /// <returns></returns>
        public static TimeSpan Days(this int days) =>
            new TimeSpan(days, 0, 0, 0);
    }
}
