namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：101. 对称二叉树
    /// 难度：简单
    /// 描述：给定一个二叉树，检查它是否是镜像对称的。
    /// </summary>
    public class IsSymmetric
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public bool Excution1(TreeNode root)
        {
            if (root == null) return true;

            return ExcutionPrivate(root.left, root.right);
        }

        private bool ExcutionPrivate(TreeNode left, TreeNode right)
        {
            if(left == null && right == null)
            {
                return true;
            }
            else if(left != null && right != null && left.val == right.val)
            {
                return ExcutionPrivate(left.left, right.right) && ExcutionPrivate(left.right, right.left);
            }
            else
            {
                return false;
            }
        }
    }
}
