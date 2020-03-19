using System.Collections.Generic;

namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：160. 相交链表
    /// 难度：简单
    /// 描述：编写一个程序，找到两个单链表相交的起始节点。
    /// </summary>
    public class GetIntersectionNode
    {
        public DeleteDuplicates.ListNode Excution1(DeleteDuplicates.ListNode headA, DeleteDuplicates.ListNode headB)
        {
            if (headA == null || headB == null) return null;

            var tmpSet = new HashSet<DeleteDuplicates.ListNode>();

            while (headA != null || headB != null)
            {
                if (headA != null)
                {
                    if (tmpSet.Contains(headA) == false)
                    {
                        tmpSet.Add(headA);
                        headA = headA.next;
                    }
                    else
                    {
                        return headA;
                    }
                }

                if (headB != null)
                {
                    if (tmpSet.Contains(headB) == false)
                    {
                        tmpSet.Add(headB);
                        headB = headB.next;
                    }
                    else
                    {
                        return headB;
                    }
                }
            }

            return null;
        }
    }
}
