using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLeetCode.Simple;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class MergeTests
    {
        public bool AreEqual(int [] a, int[] b)
        {
            if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] != b[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        [TestMethod()]
        public void Excution1Test()
        {
            var func = new Merge();
            var p = new[] { 1, 2, 3, 0, 0, 0 };
            func.Excution1(p, 3, new[] { 2, 5, 6 }, 3);
            Assert.IsTrue(AreEqual(new[] { 1, 2, 2, 3, 5, 6 }, p));

            p = new[] { 1, 10, 11, 0, 0, 0 };
            func.Excution1(p, 3, new[] { 2, 5, 6 }, 3);
            Assert.IsTrue(AreEqual(new[] { 1, 2, 5, 6, 10, 11 }, p));

            p = new[] { 9, 10, 11, 0, 0, 0 };
            func.Excution1(p, 3, new[] { 2, 5, 6 }, 3);
            Assert.IsTrue(AreEqual(new[] { 2, 5, 6, 9, 10, 11 }, p));

            p = new[] { 9, 10, 11, 0, 0, 0 };
            func.Excution1(p, 3, new[] { 12, 15, 16 }, 3);
            Assert.IsTrue(AreEqual(new[] { 9, 10, 11, 12, 15, 16 }, p));

            p = new[] { 0, 0, 0 };
            func.Excution1(p, 0, new[] { 2, 5, 6 }, 3);
            Assert.IsTrue(AreEqual(new[] { 2, 5, 6 }, p));


            p = new[] { 1, 2, 3 };
            func.Excution1(p, 3, new[] { 1 }, 0);
            Assert.IsTrue(AreEqual(new[] { 1, 2, 3 }, p));
        }
    }
}