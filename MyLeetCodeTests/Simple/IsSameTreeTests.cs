using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLeetCode.Simple;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class IsSameTreeTests
    {
        [TestMethod()]
        public void Excution1Test()
        {
            var func = new IsSameTree();

            Assert.IsTrue(func.Excution1(new IsSameTree.TreeNode(1)
            {
                left = new IsSameTree.TreeNode(2),
                right = new IsSameTree.TreeNode(3)
            }, new IsSameTree.TreeNode(1)
            {
                left = new IsSameTree.TreeNode(2),
                right = new IsSameTree.TreeNode(3)
            }));

            Assert.IsFalse(func.Excution1(new IsSameTree.TreeNode(1)
            {
                left = new IsSameTree.TreeNode(2)
            }, new IsSameTree.TreeNode(1)
            {
                right = new IsSameTree.TreeNode(2)
            }));

            Assert.IsFalse(func.Excution1(new IsSameTree.TreeNode(1)
            {
                left = new IsSameTree.TreeNode(2),
                right = new IsSameTree.TreeNode(1)
            }, new IsSameTree.TreeNode(1)
            {
                left = new IsSameTree.TreeNode(1),
                right = new IsSameTree.TreeNode(2)
            }));
        }
    }
}