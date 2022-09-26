using Moq;
using ReArrangeString.BL.Interfaces;
using ReArrangeString.BL.Services;

namespace ReArrengeString.Tests.Builder
{
    public class OrderStringsServiceBuilder
    {
        public IOrderStringsService Build()
        {
            return orderService;
        }

        public OrderStringsServiceBuilder()
        {
            orderService = new OrderStringsService(validator.Object);
        }

        private readonly IOrderStringsService orderService;
        private readonly Mock<IValidator> validator;
    }
}
