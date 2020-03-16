using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLeetCode.Simple;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class MaxProfit2Tests
    {
        [TestMethod()]
        public void Excution1Test()
        {
            var func = new MaxProfit2();

            Assert.AreEqual(7, func.Excution1(new[] {7, 1, 5, 3, 6, 4}));
            Assert.AreEqual(4, func.Excution1(new[] {1, 2, 3, 4, 5}));
            Assert.AreEqual(0, func.Excution1(new[] {7, 6, 4, 3, 1}));
        }
    }
}