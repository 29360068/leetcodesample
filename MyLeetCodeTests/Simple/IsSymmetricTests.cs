using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class IsSymmetricTests
    {
        [TestMethod()]
        public void Excution1Test()
        {
            var func = new IsSymmetric();

            Assert.IsTrue(func.Excution1(new IsSymmetric.TreeNode(1)
            {
                left = new IsSymmetric.TreeNode(2)
                {
                    left = new IsSymmetric.TreeNode(3)
                },
                right = new IsSymmetric.TreeNode(2)
                {
                    right = new IsSymmetric.TreeNode(3)
                }
            }));

            Assert.IsFalse(func.Excution1(new IsSymmetric.TreeNode(1)
            {
                left = new IsSymmetric.TreeNode(2),
                right = new IsSymmetric.TreeNode(3)
            }));

            Assert.IsTrue(func.Excution1(new IsSymmetric.TreeNode(1)));

            Assert.IsTrue(func.Excution1(new IsSymmetric.TreeNode(1)
            {
                left = new IsSymmetric.TreeNode(2),
                right = new IsSymmetric.TreeNode(2)
            }));

            Assert.IsTrue(func.Excution1(new IsSymmetric.TreeNode(1)
            {
                left = new IsSymmetric.TreeNode(2)
                {
                    left = new IsSymmetric.TreeNode(3),
                    right = new IsSymmetric.TreeNode(4)
                },
                right = new IsSymmetric.TreeNode(2)
                {
                    left = new IsSymmetric.TreeNode(4),
                    right = new IsSymmetric.TreeNode(3)
                }
            }));

            Assert.IsFalse(func.Excution1(new IsSymmetric.TreeNode(1)
            {
                left = new IsSymmetric.TreeNode(2)
                {
                    right = new IsSymmetric.TreeNode(3)
                },
                right = new IsSymmetric.TreeNode(2)
                {
                    right = new IsSymmetric.TreeNode(3)
                }
            }));
        }
    }
}