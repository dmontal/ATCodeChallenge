using System;
using NUnit.Framework;
using ReArrengeString.Tests.Builder;

namespace ReArrengeString.Tests
{
    public class OrderStringServiceTests
    {
        [Test]
        public void GetOrderStrings_Success()
        {
            // arrenge
            var sut = builder.UseIsValid(true)
                .Build();
            // act
            var result = sut.GetOrderStrings("Sonia Maria Wood Dempster", new char[] {'4', '3', '2', '1' });
            // assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result is string[]);
            Assert.AreEqual(4, result.Length);
        }

        [Test]
        public void GetOrderStrings_StringsIsNull()
        {
            // arrenge
            var sut = builder.Build();
            // act
            var result = sut.GetOrderStrings(null, new char[] { '4', '3', '2', '1' });
            // assert
            Assert.IsTrue(result.Length == 0);
        }

        [Test]
        public void GetOrderStrings_OrderSequenceIsNull()
        {
            // arrenge
            var sut = builder.Build();
            // act
            var result = sut.GetOrderStrings("Sonia Maria Wood Dempster", null);
            // assert
            Assert.IsTrue(result.Length == 0);
        }

        private readonly OrderStringsServiceBuilder builder = new OrderStringsServiceBuilder();
    }
}