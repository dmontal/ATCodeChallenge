using System;

namespace ReArrangeString.BL.Interfaces
{
    /// <summary>
    /// Describes the behavior and the member
    /// of a string ordering service
    /// </summary>
    public interface IOrderStringsService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strings"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        public string[] GetOrderStrings(String strings, char[]order);
    }
}
