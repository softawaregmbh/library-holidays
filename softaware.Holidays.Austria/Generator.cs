using softaware.Holidays.Model;
using System;
using System.Collections.Generic;

namespace softaware.Holidays.Austria
{
    public static class Generator
    {
        public static IEnumerable<Holiday> ForAustria(this Holidays.Generator generator, int year)
        {
            var easterSunday = generator.EasterSundayGregorian(year);

            Holiday WithDate(string name, int month, int day) => new Holiday { Name = name, Date = new DateTime(easterSunday.Year, month, day) };
            Holiday BeforeEaster(string name, int days) => new Holiday { Name = name, Date = easterSunday.Subtract(new TimeSpan(days, 0, 0, 0)) };
            Holiday AfterEaster(string name, int days) => new Holiday { Name = name, Date = easterSunday.Add(new TimeSpan(days, 0, 0, 0)) };

            return new List<Holiday>
            {
                WithDate("Neujahr", month: 1, day: 1),
                WithDate("Heilige Drei Könige", month: 1, day: 6),
                BeforeEaster("Karfreitag", days: 2),
                AfterEaster("Ostermontag", days: 1),
                WithDate("Staatsfeiertag", month: 5, day: 1),
                AfterEaster("Christi Himmelfahrt", days: 39),
                AfterEaster("Pfingstmontag", days: 50),
                AfterEaster("Fronleichnam", days: 60),
                WithDate("Mariä Himmelfahrt", month: 8, day: 15),
                WithDate("Nationalfeiertag", month: 10, day: 26),
                WithDate("Allerheiligen", month: 11, day: 1),
                WithDate("Maria Empfängnis", month: 12, day: 8),
                WithDate("Christtag", month: 12, day: 25),
                WithDate("Stefanitag", month: 12, day: 26)
            };
        }
    }
}
