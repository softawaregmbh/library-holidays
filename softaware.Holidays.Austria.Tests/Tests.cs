using System;
using System.Collections.Generic;
using Xunit;

namespace softaware.Holidays.Austria.Tests
{
    public class Tests
    {
        [Fact]
        public void Holidays2018()
        {
            var holidays = new Holidays.Generator().ForAustria(2018);

            Assert.Equal(holidays, new List<Model.Holiday>() {
                new Model.Holiday { Name = "Neujahr", Date = new DateTime(2018, 1, 1) },
                new Model.Holiday { Name = "Heilige Drei Könige", Date = new DateTime(2018, 1, 6) },
                new Model.Holiday { Name = "Karfreitag", Date = new DateTime(2018, 3, 30) },
                new Model.Holiday { Name = "Ostersonntag", Date = new DateTime(2018, 4, 1) },
                new Model.Holiday { Name = "Ostermontag", Date = new DateTime(2018, 4, 2) },
                new Model.Holiday { Name = "Staatsfeiertag", Date = new DateTime(2018, 5, 1) },
                new Model.Holiday { Name = "Christi Himmelfahrt", Date = new DateTime(2018, 5, 10) },
                new Model.Holiday { Name = "Pfingstmontag", Date = new DateTime(2018, 5, 21) },
                new Model.Holiday { Name = "Fronleichnam", Date = new DateTime(2018, 5, 31) },
                new Model.Holiday { Name = "Mariä Himmelfahrt", Date = new DateTime(2018, 8, 15) },
                new Model.Holiday { Name = "Nationalfeiertag", Date = new DateTime(2018, 10, 26) },
                new Model.Holiday { Name = "Allerheiligen", Date = new DateTime(2018, 11, 1) },
                new Model.Holiday { Name = "Mariä Empfängnis", Date = new DateTime(2018, 12, 8) },
                new Model.Holiday { Name = "Christtag", Date = new DateTime(2018, 12, 25) },
                new Model.Holiday { Name = "Stefanitag", Date = new DateTime(2018, 12, 26) },
            });
        }
    }
}
