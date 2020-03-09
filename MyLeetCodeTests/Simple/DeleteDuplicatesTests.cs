using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class DeleteDuplicatesTests
    {
        private bool AreaEqual(DeleteDuplicates.ListNode node1, DeleteDuplicates.ListNode node2)
        {
            while (node1 != null && node2 != null)
            {
                if (node1.val != node2.val)
                {
                    return false;
                }

                node1 = node1.next;
                node2 = node2.next;
            }

            if (node1 == null && node2 == null)
            {
                return true;
            }

            return false;
        }

        [TestMethod()]
        public void Excution1Test()
        {
            var func = new DeleteDuplicates();

            Assert.IsTrue(AreaEqual(new DeleteDuplicates.ListNode(1)
            {
                next = new DeleteDuplicates.ListNode(2)
            },
            func.Excution1(new DeleteDuplicates.ListNode(1)
            {
                next = new DeleteDuplicates.ListNode(1)
                {
                    next = new DeleteDuplicates.ListNode(2)
                }
            })));

            Assert.IsTrue(AreaEqual(new DeleteDuplicates.ListNode(1)
            {
                next = new DeleteDuplicates.ListNode(2)
                {
                    next = new DeleteDuplicates.ListNode(3)
                }
            },
            func.Excution1(new DeleteDuplicates.ListNode(1)
            {
                next = new DeleteDuplicates.ListNode(1)
                {
                    next = new DeleteDuplicates.ListNode(2)
                    {
                        next = new DeleteDuplicates.ListNode(3)
                        {
                            next = new DeleteDuplicates.ListNode(3)
                        }
                    }
                }
            })));
        }
    }
}