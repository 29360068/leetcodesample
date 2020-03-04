using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class MaxSubArrayTests
    {
        [TestMethod()]
        public void Excution1Test()
        {
            var func = new MaxSubArray();

            Assert.AreEqual(6, func.Excution1(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));

            Assert.AreEqual(0, func.Excution1(new int[] { }));

            Assert.AreEqual(-2, func.Excution1(new int[] { -2 }));

            Assert.AreEqual(-1, func.Excution1(new int[] { -2, -1, -3 }));

            Assert.AreEqual(5, func.Excution1(new int[] { 5, -2, -1, -3, 1 }));
        }
    }
}