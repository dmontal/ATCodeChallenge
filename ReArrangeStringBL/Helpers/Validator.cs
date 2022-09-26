using ReArrangeString.BL.Interfaces;
using System;

namespace ReArrangeString.BL.Helpers
{
    /// <summary>
    /// 
    /// </summary>
    public class Validator : IValidator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strings"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        public bool IsValid(String strings, char[] order)
        {
            if (strings == null)
                throw new ValidationException("strings array cannot be null");
            if (order == null)
                throw new ValidationException("order array cannot be null");
            return true;
        }
    }
}
