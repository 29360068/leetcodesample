using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLeetCode.Simple;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class TrailingZeroesTests
    {
        [TestMethod()]
        public void Excution1Test()
        {
            var func = new TrailingZeroes();
            Assert.AreEqual(0, func.Excution1(1));
            Assert.AreEqual(1, func.Excution1(5));
            Assert.AreEqual(2, func.Excution1(10));
            Assert.AreEqual(6, func.Excution1(25));
            Assert.AreEqual(7, func.Excution1(30));
        }
    }
}