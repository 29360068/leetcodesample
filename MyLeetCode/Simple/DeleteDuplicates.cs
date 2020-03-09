namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：83. 删除排序链表中的重复元素
    /// 难度：简单
    /// 描述：给定一个排序链表，删除所有重复的元素，使得每个元素只出现一次。
    /// </summary>
    public class DeleteDuplicates
    {

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode Excution1(ListNode head)
        {
            var root = head;
            ListNode pre = null;
            while(head != null)
            {
                if(pre == null || pre.val != head.val)
                {
                    pre = head;
                }
                else
                {
                    pre.next = head.next;
                }

                head = head.next;
            }

            return root;
        }
    }
}
