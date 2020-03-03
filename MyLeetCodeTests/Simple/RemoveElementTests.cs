using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class RemoveElementTests
    {
        [TestMethod()]
        public void Excution1Test()
        {
            var func = new RemoveElement();

            Assert.AreEqual(2, func.Excution1(new int[] { 3, 2, 2, 3 }, 3));

            Assert.AreEqual(5, func.Excution1(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2));

            Assert.AreEqual(5, func.Excution1(new int[] { 0, 0, 2, 2, 3, 0, 4, 2 }, 0));

            Assert.AreEqual(4, func.Excution1(new int[] { 0, 0, 2, 2, 3, 0, 2, 2 }, 2));
        }
    }
}