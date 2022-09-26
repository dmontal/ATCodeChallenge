using Moq;
using ReArrangeString.BL.Interfaces;
using ReArrangeString.BL.Services;

namespace ReArrengeString.Tests.Builder
{
    public class OrderStringsServiceBuilder
    {
        public OrderStringsServiceBuilder UseIsValid(bool expected)
        {
            validator.Setup(x => x.IsValid(It.IsAny<string>(), It.IsAny<char[]>())).Returns(expected);
            return this;
        }

        public IOrderStringsService Build()
        {
            return orderService;
        }

        public OrderStringsServiceBuilder()
        {
            validator = new Mock<IValidator>();
            orderService = new OrderStringsService(validator.Object);
        }

        private readonly IOrderStringsService orderService;
        private readonly Mock<IValidator> validator;
    }
}
