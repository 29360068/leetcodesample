using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLeetCode.Simple;
using System;
using System.Collections.Generic;
using System.Text;
using MyLeetCodeTests;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class TwoSum2Tests
    {
        [TestMethod()]
        public void Excution1Test()
        {
            var func = new TwoSum2();
            Assert.IsTrue(new[] {1, 2}.AreEqual(func.Excution1(new[] {2, 7, 11, 15}, 9)));
            Assert.IsTrue(new[] {1, 4}.AreEqual(func.Excution1(new[] {2, 7, 11, 15}, 17)));
            Assert.IsTrue(new[] {2, 3}.AreEqual(func.Excution1(new[] {2, 7, 11, 15},18)));

        }
    }
}