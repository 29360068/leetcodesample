using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class LevelOrderBottomTests
    {
        public static bool AreEqual(IList<IList<int>> expect, IList<IList<int>> target)
        {
            for (int i = 0; i < expect.Count; i++)
            {
                if (i >= target.Count) return false;

                for (int j = 0; j < expect[i].Count; j++)
                {
                    if (j >= target[i].Count) return false;

                    if (expect[i][j] != target[i][j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        [TestMethod()]
        public void Excution1Test()
        {
            var func = new LevelOrderBottom();

            Assert.IsTrue(AreEqual(new List<IList<int>>
            {
                new List<int> {45},
                new List<int> {30, 40, 15, 7},
                new List<int> {9, 20},
                new List<int> {3}
            }, func.Excution1(new IsSameTree.TreeNode(3)
            {
                left = new IsSameTree.TreeNode(9)
                {
                    left = new IsSameTree.TreeNode(30)
                    {
                        left = new IsSameTree.TreeNode(45)
                    },
                    right = new IsSameTree.TreeNode(40)
                },
                right = new IsSameTree.TreeNode(20)
                {
                    left = new IsSameTree.TreeNode(15),
                    right = new IsSameTree.TreeNode(7)
                }
            })));

            Assert.IsTrue(AreEqual(new List<IList<int>>
            {
                new List<int> {15, 7},
                new List<int> {9, 20},
                new List<int> {3}
            }, func.Excution1(new IsSameTree.TreeNode(3)
            {
                left = new IsSameTree.TreeNode(9),
                right = new IsSameTree.TreeNode(20)
                {
                    left = new IsSameTree.TreeNode(15),
                    right = new IsSameTree.TreeNode(7)
                }
            })));

            Assert.IsTrue(AreEqual(new List<IList<int>>
            {
                new List<int>{3}
            }, func.Excution1(new IsSameTree.TreeNode(3))));

            Assert.IsTrue(AreEqual(new List<IList<int>>
            {
                new List<int> {7},
                new List<int> {20},
                new List<int> {3}
            }, func.Excution1(new IsSameTree.TreeNode(3)
            {
                right = new IsSameTree.TreeNode(20)
                {
                    right = new IsSameTree.TreeNode(7)
                }
            })));
        }
    }
}