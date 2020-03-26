using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLeetCode.Simple;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class TitleToNumberTests
    {
        [TestMethod()]
        public void Excution1Test()
        {
            var func = new TitleToNumber();
            Assert.AreEqual(1, func.Excution1("A"));
            Assert.AreEqual(2, func.Excution1("B"));
            Assert.AreEqual(3, func.Excution1("C"));
            Assert.AreEqual(26, func.Excution1("Z"));
            Assert.AreEqual(27, func.Excution1("AA"));
            Assert.AreEqual(28, func.Excution1("AB"));
            Assert.AreEqual(701, func.Excution1("ZY"));
            Assert.AreEqual(702, func.Excution1("ZZ"));
            Assert.AreEqual(703, func.Excution1("AAA"));
        }
    }
}