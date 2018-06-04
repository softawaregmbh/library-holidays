using System;

namespace softaware.Holidays.Model
{
    public class Holiday
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public override bool Equals(object obj) =>
            obj is Holiday holiday && this.Name == holiday.Name && this.Date == holiday.Date;

        public override int GetHashCode() =>
            $"{Name}{Date.ToFileTimeUtc()}".GetHashCode();

        public override string ToString() =>
            $"{Name} ({Date})";
    }
}
