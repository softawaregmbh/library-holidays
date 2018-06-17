using System;

namespace softaware.Holidays.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Holiday
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj) =>
            obj is Holiday holiday && this.Name == holiday.Name && this.Date == holiday.Date;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode() =>
            $"{Name}{Date.ToFileTimeUtc()}".GetHashCode();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString() =>
            $"{Name} ({Date})";
    }
}
