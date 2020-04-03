using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLeetCode.Simple;
using System;
using System.Collections.Generic;
using System.Text;
using MyLeetCodeTests;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class RotateTests
    {
        [TestMethod()]
        public void ExcutionTest()
        {
            var func = new Rotate();

            var source = new[] {1, 2,3,4,5,6};
            func.Excution(source, 2);
            Assert.IsTrue(new[] {5, 6, 1, 2, 3, 4}.AreEqual(source));
            
            source = new[] {1, 2};
            func.Excution(source, 2);
            Assert.IsTrue(new[] {1, 2}.AreEqual(source));

            source = new[] {1, 2, 3, 4, 5, 6, 7};
            func.Excution(source, 3);
            Assert.IsTrue(new[] {5, 6, 7, 1, 2, 3, 4}.AreEqual(source));

            source = new[] {1, 2, 3, 4, 5, 6, 7, 8};
            func.Excution(source, 6);
            Assert.IsTrue(new[] {3, 4, 5, 6, 7, 8, 1, 2}.AreEqual(source));
        }
    }
}