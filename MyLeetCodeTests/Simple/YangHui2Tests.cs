using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLeetCode.Simple;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using MyLeetCodeTests;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class YangHui2Tests
    {



        [TestMethod()]
        public void GetRowTest()
        {
            var func = new YangHui2();
            
            Assert.IsTrue(Common.AreEqual(new List<int>() {1}, func.GetRow(0)));
            Assert.IsTrue(Common.AreEqual(new List<int>() {1, 1}, func.GetRow(1)));
            Assert.IsTrue(Common.AreEqual(new List<int>() {1, 2, 1}, func.GetRow(2)));
            Assert.IsTrue(Common.AreEqual(new List<int>() {1, 3, 3, 1}, func.GetRow(3)));
            Assert.IsTrue(Common.AreEqual(new List<int>() {1, 4, 6, 4, 1}, func.GetRow(4)));
        }
    }
}