using System;

namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：104. 二叉树的最大深度
    /// 难度：简单
    /// 描述：给定一个二叉树，找出其最大深度。
    /// </summary>
    public class MaxDepth
    {
        public int Excution1(IsSameTree.TreeNode root)
        {
            if (root == null) return 0;
            return 1 + Math.Max(Excution1(root.left), Excution1(root.right));
        }
    }
}
