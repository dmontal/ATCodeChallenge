using System;
using System.Collections.Generic;
using System.Text;

namespace ReArrangeString.BL.Helpers
{
    /// <summary>
    /// This class represents a Validation Exception thrown by a Validator
    /// </summary>
    public class ValidationException : Exception
    {
        /// <summary>
        /// Validation Excpetion class constructor that receives a message to use
        /// </summary>
        /// <param name="message"></param>
        public ValidationException(string message) : base(message)
        {
        }
    }
}
