using ReArrangeString.BL.Interfaces;
using System;
using System.Collections.Generic;

namespace ReArrangeString.BL.Services
{
    public class OrderStringsService : IOrderStringsService
    {
        private readonly IValidator _validator;

        /// <summary>
        /// Creates a new instance of a OrderStringsService
        /// </summary>
        /// <param name="validator"></param>
        public OrderStringsService(IValidator validator)
        {
            _validator = validator;
        }

        /// <summary>
        /// Order an array of strings base on the sequence order passed as an array of ordered indexes
        /// </summary>
        /// <param name="strings"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        public string[] GetOrderStrings(String strings, char[] order)
        {
            List<string> orderedStrings = new List<string>();
            try
            {   
                // Do sanity check of input names and order sequence
                if (_validator.IsValid(strings, order))
                {
                    for (int i = 0; i < order.Length; i++)
                    {
                        var list = strings.Split(' ');
                        var index = int.Parse(order[i].ToString());
                        orderedStrings.Add(list[index - 1]);
                    }
                }
            }
            catch (Exception ex)
            {
                return Array.Empty<string>();
            }
            return orderedStrings.ToArray();
        }
    }
}
