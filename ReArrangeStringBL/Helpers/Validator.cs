using ReArrangeString.BL.Interfaces;
using System;

namespace ReArrangeString.BL.Helpers
{
    /// <summary>
    /// This class is responsible to validate input strings and order sequence
    /// </summary>
    public class Validator : IValidator
    {
        /// <summary>
        /// This method validates input strings and order sequence
        /// </summary>
        /// <param name="strings">The array of names in separeted by comma format</param>
        /// <param name="order">The array of order sequece in character format</param>
        /// <returns>true is strings to order or order sequence arrays are valid
        /// otherwise it throws a ValidationExcpetion with a message</returns>
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
