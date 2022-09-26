using Microsoft.Extensions.DependencyInjection;
using ReArrangeString.BL.Helpers;
using ReArrangeString.BL.Interfaces;
using ReArrangeString.BL.Services;

namespace ReArrengeString.API.Utility
{
    /// <summary>
    /// This class contains the extension method to add the services
    /// in the startup class
    /// </summary>
    public static class AddServiceConfigurationExtension
    {
        /// <summary>
        /// Injects services to the service collection
        /// </summary>
        /// <param name="services"></param>
        public static void AddServicesConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IValidator, Validator>();
            services.AddScoped<IOrderStringsService, OrderStringsService>();
        }
    }
}
