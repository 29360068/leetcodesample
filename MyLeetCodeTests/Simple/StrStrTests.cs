using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLeetCode.Simple;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class StrStrTests
    {
        [TestMethod()]
        public void Excution1Test()
        {
            var func = new StrStr();

            Assert.AreEqual(-1, func.Excution1("", "ll"));
            Assert.AreEqual(2, func.Excution1("hello", "ll"));
            Assert.AreEqual(-1, func.Excution1("aaaaa", "bba"));
            Assert.AreEqual(8, func.Excution1("abbbbppppoppppo", "po"));
            Assert.AreEqual(0, func.Excution1("abbbbppppoppppo", "abbbb"));
            Assert.AreEqual(13, func.Excution1("abbbbppppoppppb", "pb"));
        }
    }
}