using softaware.Holidays.Model;
using System;
using System.Collections.Generic;

namespace softaware.Holidays.Austria
{
    public static class Generator
    {
        public static IEnumerable<Holiday> ForAustria(this Holidays.Generator generator, int year)
        {
            var holiday = generator.Create(year);

            yield return holiday.WithDate("Neujahr", month: 1, day: 1);
            yield return holiday.WithDate("Heilige Drei Könige", month: 1, day: 6);
            yield return holiday.BeforeEaster("Karfreitag", days: 2);
            yield return holiday.AfterEaster("Ostermontag", days: 1);
            yield return holiday.WithDate("Staatsfeiertag", month: 5, day: 1);
            yield return holiday.AfterEaster("Christi Himmelfahrt", days: 39);
            yield return holiday.AfterEaster("Pfingstmontag", days: 50);
            yield return holiday.AfterEaster("Fronleichnam", days: 60);
            yield return holiday.WithDate("Mariä Himmelfahrt", month: 8, day: 15);
            yield return holiday.WithDate("Nationalfeiertag", month: 10, day: 26);
            yield return holiday.WithDate("Allerheiligen", month: 11, day: 1);
            yield return holiday.WithDate("Mariä Empfängnis", month: 12, day: 8);
            yield return holiday.WithDate("Christtag", month: 12, day: 25);
            yield return holiday.WithDate("Stefanitag", month: 12, day: 26);
        }
    }
}
