using System;
using System.Collections.Generic;
using Xunit;
using System.Linq;

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
                new Model.Holiday { Name = "Valentinstag", Date = new DateTime(2018, 2, 14) },
                new Model.Holiday { Name = "Karfreitag", Date = new DateTime(2018, 3, 30) },
                new Model.Holiday { Name = "Ostersonntag", Date = new DateTime(2018, 4, 1) },
                new Model.Holiday { Name = "Ostermontag", Date = new DateTime(2018, 4, 2) },
                new Model.Holiday { Name = "Staatsfeiertag", Date = new DateTime(2018, 5, 1) },
                new Model.Holiday { Name = "Muttertag", Date = new DateTime(2018, 5, 13) },
                new Model.Holiday { Name = "Christi Himmelfahrt", Date = new DateTime(2018, 5, 10) },
                new Model.Holiday { Name = "Pfingstmontag", Date = new DateTime(2018, 5, 21) },
                new Model.Holiday { Name = "Fronleichnam", Date = new DateTime(2018, 5, 31) },
                new Model.Holiday { Name = "Vatertag", Date = new DateTime(2018, 6, 10) },
                new Model.Holiday { Name = "Mariä Himmelfahrt", Date = new DateTime(2018, 8, 15) },
                new Model.Holiday { Name = "Nationalfeiertag", Date = new DateTime(2018, 10, 26) },
                new Model.Holiday { Name = "Halloween", Date = new DateTime(2018, 10, 31) },
                new Model.Holiday { Name = "Allerheiligen", Date = new DateTime(2018, 11, 1) },
                new Model.Holiday { Name = "Mariä Empfängnis", Date = new DateTime(2018, 12, 8) },
                new Model.Holiday { Name = "Christtag", Date = new DateTime(2018, 12, 25) },
                new Model.Holiday { Name = "Stefanitag", Date = new DateTime(2018, 12, 26) },
            });
        }

        [Fact]
        public void FathersDay()
        {
            var fathersday2018 = new Holidays.Generator().ForAustria(2018).Where(h => h.Name.Equals("Vatertag")).First().Date;
            var fathersday2019 = new Holidays.Generator().ForAustria(2019).Where(h => h.Name.Equals("Vatertag")).First().Date;
            var fathersday2020 = new Holidays.Generator().ForAustria(2020).Where(h => h.Name.Equals("Vatertag")).First().Date;
            var fathersday2021 = new Holidays.Generator().ForAustria(2021).Where(h => h.Name.Equals("Vatertag")).First().Date;

            Assert.Equal(fathersday2018, new DateTime(2018, 6, 10));
            Assert.Equal(fathersday2019, new DateTime(2019, 6, 9));
            Assert.Equal(fathersday2020, new DateTime(2020, 6, 14));
            Assert.Equal(fathersday2021, new DateTime(2021, 6, 13));
        }

        [Fact]
        public void MothersDay()
        {
            var mothersday2018 = new Holidays.Generator().ForAustria(2018).Where(h => h.Name.Equals("Muttertag")).First().Date;
            var mothersday2019 = new Holidays.Generator().ForAustria(2019).Where(h => h.Name.Equals("Muttertag")).First().Date;
            var mothersday2020 = new Holidays.Generator().ForAustria(2020).Where(h => h.Name.Equals("Muttertag")).First().Date;
            var mothersday2021 = new Holidays.Generator().ForAustria(2021).Where(h => h.Name.Equals("Muttertag")).First().Date;

            Assert.Equal(mothersday2018, new DateTime(2018, 5, 13));
            Assert.Equal(mothersday2019, new DateTime(2019, 5, 12));
            Assert.Equal(mothersday2020, new DateTime(2020, 5, 10));
            Assert.Equal(mothersday2021, new DateTime(2021, 5, 9));
        }
    }
}
