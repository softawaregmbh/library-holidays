using System;

namespace softaware.Holidays.Model
{
    /// <summary>
    /// Holiday class
    /// </summary>
    public class Holiday
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj) =>
            obj is Holiday holiday && this.Name == holiday.Name && this.Date == holiday.Date;

        /// <summary>
        /// Hashcode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode() =>
            $"{Name}{Date.ToFileTimeUtc()}".GetHashCode();

        /// <summary>
        /// String representation
        /// </summary>
        /// <returns></returns>
        public override string ToString() =>
            $"{Name} ({Date})";
    }
}
