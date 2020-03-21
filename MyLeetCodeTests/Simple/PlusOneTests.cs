using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLeetCodeTests;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class PlusOneTests
    {
        [TestMethod()]
        public void Excution1Test()
        {
            var func = new PlusOne();

            Assert.IsTrue(Common.AreEqual(new[] { 1, 0, 0, 0 }, func.Excution1(new[] { 9, 9, 9 })));
            Assert.IsTrue(Common.AreEqual(new[] { 1, 2, 4 }, func.Excution1(new[] { 1, 2, 3 })));
            Assert.IsTrue(Common.AreEqual(new[] { 4, 3, 2, 2 }, func.Excution1(new[] { 4, 3, 2, 1 })));
            Assert.IsTrue(Common.AreEqual(new[] { 1 }, func.Excution1(new[] { 0 })));
            Assert.IsTrue(Common.AreEqual(new[] { 1, 0 }, func.Excution1(new[] { 9 })));
        }
    }
}