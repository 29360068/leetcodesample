namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：21. 合并两个有序链表
    /// 难度：简单
    /// 描述：将两个有序链表合并为一个新的有序链表并返回。新链表是通过拼接给定的两个链表的所有节点组成的。 
    /// </summary>
    public class MergeTwoLists
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode Excution1(ListNode l1, ListNode l2)
        {
            if(l1 == null )
            {
                return l2;
            }
            if(l2 == null)
            {
                return l1;
            }

            var small = l1.val <= l2.val ? l1: l2;
            var big = l1.val > l2.val ? l1 : l2;
            ListNode smallPre = small;
            do
            {
                while (smallPre.next != null && smallPre.next.val < big.val)
                {
                    smallPre = smallPre.next;
                }

                var bp = big;
                big = big.next;

                bp.next = smallPre.next;
                smallPre.next = bp;

                smallPre = smallPre.next;
                
            } while (big != null);

            return small;
        }

        public ListNode Excution2(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }
            if (l2 == null)
            {
                return l1;
            }

            if(l1.val < l2.val)
            {
                l1.next = Excution2(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = Excution2(l1, l2.next);
                return l2;
            }
        }
    }
}
