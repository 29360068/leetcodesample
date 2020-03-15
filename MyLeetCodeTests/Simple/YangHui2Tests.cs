using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLeetCode.Simple;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class YangHui2Tests
    {
        public bool AreEqual(IList<int> l1, IList<int> l2)
        {
            if (l1.Count != l2.Count) return true;
            for (int i = 0; i < l1.Count; i++)
            {
                if (l1[i] != l2[i])
                {
                    return false;
                }
            }

            return true;
        }


        [TestMethod()]
        public void GetRowTest()
        {
            var func = new YangHui2();
            
            Assert.IsTrue(AreEqual(new List<int>() {1}, func.GetRow(0)));
            Assert.IsTrue(AreEqual(new List<int>() {1, 1}, func.GetRow(1)));
            Assert.IsTrue(AreEqual(new List<int>() {1, 2, 1}, func.GetRow(2)));
            Assert.IsTrue(AreEqual(new List<int>() {1, 3, 3, 1}, func.GetRow(3)));
            Assert.IsTrue(AreEqual(new List<int>() {1, 4, 6, 4, 1}, func.GetRow(4)));
        }
    }
}