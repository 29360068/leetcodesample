using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class PlusOneTests
    {
        private bool AreEqual(int [] nums1, int[] nums2)
        {
            if(nums1.Length == nums2.Length)
            {
                for (int i = 0; i < nums1.Length; i++)
                {
                    if(nums1[i] != nums2[i])
                    {
                        break;
                    }
                }
                return true;
            }
            return false;
        }

        [TestMethod()]
        public void Excution1Test()
        {
            var func = new PlusOne();

            Assert.IsTrue(AreEqual(new[] { 1, 0, 0, 0 }, func.Excution1(new[] { 9, 9, 9 })));
            Assert.IsTrue(AreEqual(new[] { 1, 2, 4 }, func.Excution1(new[] { 1, 2, 3 })));
            Assert.IsTrue(AreEqual(new[] { 4, 3, 2, 2 }, func.Excution1(new[] { 4, 3, 2, 1 })));
            Assert.IsTrue(AreEqual(new[] { 1 }, func.Excution1(new[] { 0 })));
            Assert.IsTrue(AreEqual(new[] { 1, 0 }, func.Excution1(new[] { 9 })));
        }
    }
}