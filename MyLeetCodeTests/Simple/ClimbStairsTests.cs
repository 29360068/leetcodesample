using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class ClimbStairsTests
    {
        [TestMethod()]
        public void Excution1Test()
        {
            var func = new ClimbStairs();

            func.Excution1(44);

            Assert.AreEqual(2, func.Excution1(2));
            Assert.AreEqual(1, func.Excution1(1));
            Assert.AreEqual(3, func.Excution1(3));
        }
    }
}