using System;
using MoneyExchangeRatePkg;
using Moq;
using NUnit.Framework;

namespace MoqTestProject
{
    [TestFixture]
    public class UnitTest1
    {
        private IUSD_CLP_ExchangeRateFeed prvGetMockExchangeRateFeed()
        {
            Mock<IUSD_CLP_ExchangeRateFeed> mockObject = new Mock<IUSD_CLP_ExchangeRateFeed>();
            mockObject.Setup(m => m.GetActualUSDValue()).Returns(500);
            return mockObject.Object;
        }
        [Test]
        public void TestMethod1()
        {
            IUSD_CLP_ExchangeRateFeed feed = this.prvGetMockExchangeRateFeed();
            Calculator calculator = new Calculator(feed);
            int actualResult = calculator.divide(9, 3);
            int expectedResult = 3;
            Assert.AreEqual(expectedResult, actualResult);


        }
        [Test]
        public void TestMethod2()
        {
            IUSD_CLP_ExchangeRateFeed feed = this.prvGetMockExchangeRateFeed();
            Calculator calculator = new Calculator(feed);
            int actualResult = calculator.ConvertUSDtoCLP(5);
            int expectedResult = 2500;
            Assert.AreEqual(expectedResult, actualResult);


        }
    }
}
