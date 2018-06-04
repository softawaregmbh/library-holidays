using System;
using System.Collections.Generic;

namespace softaware.Holidays
{
    public class Generator
    {
        public DateTime EasterSundayGregorian(int year)
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

        public DateTime EasterSundayJulian(int year)
        {
            var k = year / 100;
            var m = 15;
            var s = 0;
            var a = year % 19;
            var d = (19 * a + m) % 30;
            var r = (d + a / 11) / 29;
            var og = 21 + d - r;
            var sz = 7 - (year + year / 4 + s) % 7;
            var oe = 7 - (og - sz) % 7;
            var os = og + oe;

            return new DateTime(year, 3 + os / 31, os % 31);
        }
    }
}
