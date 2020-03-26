using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLeetCode.Simple;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class MajorityElementTests
    {
        [TestMethod()]
        public void Excution1Test()
        {
            var func = new MajorityElement();
            Assert.AreEqual(3, func.Excution1(new[] {3}));
            Assert.AreEqual(3, func.Excution1(new[] {3, 2, 3}));
            Assert.AreEqual(2, func.Excution1(new[] {2, 2, 1, 1, 1, 2, 2}));
        }
    }
}