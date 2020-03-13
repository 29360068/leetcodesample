using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLeetCode.Simple;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class MaxDepthTests
    {
        [TestMethod()]
        public void Excution1Test()
        {
            var func = new MaxDepth();

            Assert.AreEqual(3, func.Excution1(new IsSameTree.TreeNode(3)
            {
                left = new IsSameTree.TreeNode(9),
                right = new IsSameTree.TreeNode(20)
                {
                    left = new IsSameTree.TreeNode(15),
                    right = new IsSameTree.TreeNode(78)
                }
            }));

            Assert.AreEqual(0, func.Excution1(null));

            Assert.AreEqual(1, func.Excution1(new IsSameTree.TreeNode(3)));
            Assert.AreEqual(2, func.Excution1(new IsSameTree.TreeNode(3)
            {
                right = new IsSameTree.TreeNode(2)
            }));
        }
    }
}