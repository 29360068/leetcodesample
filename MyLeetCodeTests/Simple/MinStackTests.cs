using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLeetCode.Simple;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class MinStackTests
    {
        [TestMethod()]
        public void MinStackTest()
        {
            var func = new MinStack();
            func.Push(-2);
            func.Push(0);
            func.Push(-3);
            Assert.AreEqual(-3, func.GetMin());
            func.Pop();
            Assert.AreEqual(0, func.Top());
            Assert.AreEqual(-2, func.GetMin());
            func = new MinStack();
            func.Push(0);
            func.Push(1);
            func.Push(0);
            Assert.AreEqual(0, func.GetMin());
            func.Pop();
            Assert.AreEqual(1, func.Top());
            Assert.AreEqual(0, func.GetMin());
        }
    }
}