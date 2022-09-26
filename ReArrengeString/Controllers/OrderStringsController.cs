using Microsoft.AspNetCore.Mvc;
using ReArrangeString.BL.Helpers;
using ReArrangeString.BL.Interfaces;
using System;

namespace ReArrengeString.API.Controllers
{
    /// <summary>
    /// Implements the order strings controller
    /// </summary>
    public class OrderStringsController : Controller
    {
        /// <summary>
        /// This method has the responsability to order a array of string
        /// names based on the order array sequence
        /// </summary>
        /// <param name="names">string of names as an array of strings separated by space</param>
        /// <param name="order">order sequence in the format of char array ['4','2','3','1']</param>
        /// <returns>Array of ordered string names based on order sequence</returns>
        [HttpPost("order")]
        public IActionResult Order(string names, char[] order)
        {
            string[] result = null;
            try
            {
                result = _orderService.GetOrderStrings(names, order);
            }
            catch (ValidationException vex)
            {
                BadRequest(vex.Message);
            }
            catch(Exception ex)
            {
                throw (ex);
            }
            
            return Ok(result);
        }

        public OrderStringsController(IOrderStringsService orderService)
        {
            _orderService = orderService;
        }

        /// <summary>
        /// Represents the service to order strings 
        /// </summary>
        private readonly IOrderStringsService _orderService;
    }
}
