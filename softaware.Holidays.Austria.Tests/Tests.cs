using System;
using Xunit;
using softaware.Holidays;
using System.Linq;

namespace softaware.Holidays.Austria.Tests
{
    public class Tests
    {
        [Fact]
        public void Holidays2018()
        {
            var holidays = new Holidays.Generator().ForAustria(2018);

            Assert.Contains(new Model.Holiday { Name = "Neujahr", Date = new DateTime(2018, 1, 1) }, holidays);
        }
    }
}
