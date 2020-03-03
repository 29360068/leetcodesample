using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLeetCode.Simple;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class RemoveDuplicatesTests
    {
        [TestMethod()]
        public void Excution1Test()
        {
            var func = new RemoveDuplicates();

            Assert.AreEqual(2, func.Excution1(new int[] { 1, 1, 2 }));
            Assert.AreEqual(5, func.Excution1(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }));
        }
    }
}