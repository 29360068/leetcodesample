namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：100. 相同的树
    /// 难度：简单
    /// 描述：给定两个二叉树，编写一个函数来检验它们是否相同。
    /// </summary>
    public class IsSameTree
    {
        public class TreeNode
        {
            public int val; public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public bool Excution1(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if(p != null && q != null)
            {
                if(p.val == q.val)
                {
                    return Excution1(p.left, q.left) && Excution1(p.right, q.right);
                }
            }

            return false;
        }
    }
}
