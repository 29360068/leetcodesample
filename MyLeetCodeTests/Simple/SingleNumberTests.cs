using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLeetCode.Simple;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class SingleNumberTests
    {
        [TestMethod()]
        public void Excution1Test()
        {
            var func = new SingleNumber();
            Assert.AreEqual(1, func.Excution1(new[] {1}));
            Assert.AreEqual(1, func.Excution1(new[] {2, 2, 1}));
            Assert.AreEqual(4, func.Excution1(new[] {4,1,2,1,2}));
            Assert.AreEqual(4, func.Excution1(new[] {1, 2, 1, 2, 4}));
        }
    }
}