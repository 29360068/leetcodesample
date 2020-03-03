using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class SearchInsertTests
    {
        [TestMethod()]
        public void Excution1Test()
        {
            var func = new SearchInsert();
            Assert.AreEqual(0, func.Excution1(new[] { 1, 3, 5, 6 }, 0));
            Assert.AreEqual(1, func.Excution1(new[] { 1, 3, 5, 6 }, 2));
            Assert.AreEqual(1, func.Excution1(new int[] { 1 }, 2));
            Assert.AreEqual(2, func.Excution1(new[] { 1, 3, 5, 6 }, 5));
            Assert.AreEqual(4, func.Excution1(new[] { 1, 3, 5, 6 }, 7));
            Assert.AreEqual(0, func.Excution1(new int[] { }, 1));

            
        }
    }
}