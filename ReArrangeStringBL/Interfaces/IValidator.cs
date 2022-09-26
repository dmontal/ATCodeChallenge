using System;

namespace ReArrangeString.BL.Interfaces
{
    /// <summary>
    /// Describes the behavior and the member
    /// of a validator
    /// </summary>
    public interface IValidator
    {
        /// <summary>
        /// This method has the resposability of
        /// validating the strings to order and 
        /// the ordering sequence passed
        /// </summary>
        /// <param name="strings"></param>
        /// <param name="order"></param>
        /// <returns>true is strings to order or order sequence arrays are valid
        /// otherwise it throws a ValidationException with a message
        /// </returns>
        public bool IsValid(String strings, char[] order);
    }
}
