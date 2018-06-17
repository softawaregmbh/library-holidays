using softaware.Holidays.Model;
using softaware.Holidays.Extensions;
using System;
using System.Collections.Generic;

namespace softaware.Holidays.Austria
{
    /// <summary>
    /// 
    /// </summary>
    public static class Generator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public static IEnumerable<Holiday> ForAustria(this Holidays.Generator generator, int year)
        {
            var holiday = generator.Create(year);

            yield return holiday.WithDate("Neujahr", 1.January);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public static IEnumerable<Holiday> ForAustria2(this Holidays.Generator generator, int year) =>
            generator.Generate(year, (withDate, beforeEaster, afterEaster) => {
                yield return withDate("Neujahr", 1.January);
                yield return withDate("Heilige Drei Könige", 6.January);
                yield return beforeEaster("Karfreitag", 2.Days);
                yield return afterEaster("Ostermontag", 1.Day);
                yield return withDate("Staatsfeiertag", 1.May);
                yield return afterEaster("Christi Himmelfahrt", 39.Days);
                yield return afterEaster("Pfingstmontag", 50.Days);
                yield return afterEaster("Fronleichnam", 60.Days);
                yield return withDate("Mariä Himmelfahrt", 15.August);
                yield return withDate("Nationalfeiertag", 26.October);
                yield return withDate("Allerheiligen", 1.November);
                yield return withDate("Mariä Empfängnis", 8.December);
                yield return withDate("Christtag", 25.December);
                yield return withDate("Stefanitag", 26.December);
            });
    }
}
