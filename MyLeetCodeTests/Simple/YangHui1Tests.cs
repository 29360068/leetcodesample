using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MyLeetCodeTests;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class YangHui1Tests
    {
        [TestMethod()]
        public void GenerateTest()
        {
            var func = new YangHui1();

            Assert.IsTrue(Common.AreEqual(new List<IList<int>>
            {
                new List<int> {1},
                new List<int> {1, 1},
                new List<int> {1, 2, 1}
            }, func.Generate(3)));

            Assert.IsTrue(Common.AreEqual(new List<IList<int>>
            {
                new List<int> {1}
            }, func.Generate(1)));

            Assert.IsTrue(Common.AreEqual(new List<IList<int>>
            {
                new List<int> {1},
                new List<int> {1, 1}
            }, func.Generate(2)));

            Assert.IsTrue(Common.AreEqual(new List<IList<int>>
            {
                new List<int> {1},
                new List<int> {1, 1},
                new List<int> {1, 2, 1},
                new List<int> {1, 3, 3, 1}
            }, func.Generate(4)));

            Assert.IsTrue(Common.AreEqual(new List<IList<int>>
            {
                new List<int> {1},
                new List<int> {1, 1},
                new List<int> {1, 2, 1},
                new List<int> {1, 3, 3, 1},
                new List<int> {1, 4, 6, 4, 1}
            }, func.Generate(5)));
        }
    }
}