using System;

namespace softaware.Holidays.Model
{
    /// <summary>
    /// Represents a Holiday
    /// </summary>
    public class Holiday
    {
        /// <summary>
        /// Name of the holiday.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Date of the holiday.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Indicates if the day is a working day or not.
        /// </summary>
        public bool WorkingDay { get; set; }

        /// <summary>
        /// Checks whether two holidays are the same.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj) =>
            obj is Holiday holiday && this.Name == holiday.Name && this.Date == holiday.Date;
        
        /// <summary>
        /// Returns the hash code for this holiday.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode() =>
            $"{Name}{Date.ToFileTimeUtc()}".GetHashCode();
        
        /// <summary>
        /// Returns the string representation of the holiday.
        /// </summary>
        /// <returns></returns>
        public override string ToString() =>
            $"{Name} ({Date})";
    }
}
