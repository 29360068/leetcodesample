using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLeetCode.Simple.Tests
{
    [TestClass()]
    public class GetIntersectionNodeTests
    {
        [TestMethod()]
        public void Get_Right_Result_When_Intersect_Middle()
        {
            var func = new GetIntersectionNode();

            var t1 = new DeleteDuplicates.ListNode(4)
            {
                next = new DeleteDuplicates.ListNode(1)
                {
                    next = new DeleteDuplicates.ListNode(8)
                    {
                        next = new DeleteDuplicates.ListNode(4)
                        {
                            next = new DeleteDuplicates.ListNode(5)
                        }
                    }
                }
            };
            var t2 = new DeleteDuplicates.ListNode(5)
            {
                next = new DeleteDuplicates.ListNode(0)
                {
                    next = new DeleteDuplicates.ListNode(1)
                    {
                        next = t1.next.next
                    }
                }
            };
            Assert.AreEqual(t1.next.next, func.Excution1(t1, t2));
        }

        [TestMethod()]
        public void Get_Right_Result_When_Intersect_Start()
        {
            var func = new GetIntersectionNode();

            var t1 = new DeleteDuplicates.ListNode(4)
            {
                next = new DeleteDuplicates.ListNode(1)
                {
                    next = new DeleteDuplicates.ListNode(8)
                    {
                        next = new DeleteDuplicates.ListNode(4)
                        {
                            next = new DeleteDuplicates.ListNode(5)
                        }
                    }
                }
            };
            var t2 = t1.next.next;
            Assert.AreEqual(t1.next.next, func.Excution1(t1, t2));
        }

        [TestMethod()]
        public void Get_Right_Result_When_Intersect_End()
        {
            var func = new GetIntersectionNode();

            var t1 = new DeleteDuplicates.ListNode(4)
            {
                next = new DeleteDuplicates.ListNode(1)
                {
                    next = new DeleteDuplicates.ListNode(8)
                    {
                        next = new DeleteDuplicates.ListNode(4)
                        {
                            next = new DeleteDuplicates.ListNode(5)
                        }
                    }
                }
            };
            var t2 = new DeleteDuplicates.ListNode(5)
            {
                next = new DeleteDuplicates.ListNode(0)
                {
                    next = new DeleteDuplicates.ListNode(1)
                    {
                        next = t1.next.next.next.next
                    }
                }
            };

            Assert.AreEqual( t1.next.next.next.next, func.Excution1(t1, t2));
        }

        [TestMethod()]
        public void Get_Right_Result_When_Intersect_Null()
        {
            var func = new GetIntersectionNode();

            var t1 = new DeleteDuplicates.ListNode(4)
            {
                next = new DeleteDuplicates.ListNode(1)
                {
                    next = new DeleteDuplicates.ListNode(8)
                    {
                        next = new DeleteDuplicates.ListNode(4)
                        {
                            next = new DeleteDuplicates.ListNode(5)
                        }
                    }
                }
            };
            var t2 = new DeleteDuplicates.ListNode(5)
            {
                next = new DeleteDuplicates.ListNode(0)
                {
                    next = new DeleteDuplicates.ListNode(1)
                    {
                    }
                }
            };

            Assert.AreEqual(null, func.Excution1(t1, t2));
        }

        [TestMethod()]
        public void Get_Right_Result_When_One_Node_Is_Null()
        {
            var func = new GetIntersectionNode();

            var t1 = new DeleteDuplicates.ListNode(4)
            {
                next = new DeleteDuplicates.ListNode(1)
                {
                    next = new DeleteDuplicates.ListNode(8)
                    {
                        next = new DeleteDuplicates.ListNode(4)
                        {
                            next = new DeleteDuplicates.ListNode(5)
                        }
                    }
                }
            };
            DeleteDuplicates.ListNode t2 = null;

            Assert.AreEqual(null, func.Excution1(t1, t2));
        }
    }
}