using MyLeetCode.Simple;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class MaxProfitTests
    {
        [TestMethod()]
        public void Excution1Test()
        {
            var func = new MaxProfit();

            Assert.AreEqual(5, func.Excution1(new[] { 7, 1, 5, 3, 6, 4 }));
            Assert.AreEqual(0, func.Excution1(new[] { 7, 6, 4, 3, 1 }));
            Assert.AreEqual(0, func.Excution1(new[] { 1 }));
        }

        [TestMethod()]
        public void Excution2Test()
        {
            var func = new MaxProfit();

            Assert.AreEqual(5, func.Excution2(new[] { 7, 1, 5, 3, 6, 4 }));
            Assert.AreEqual(0, func.Excution2(new[] { 7, 6, 4, 3, 1 }));
            Assert.AreEqual(0, func.Excution2(new[] { 1 }));
        }
    }
}