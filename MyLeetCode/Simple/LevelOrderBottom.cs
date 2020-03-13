using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：107. 二叉树的层次遍历 II
    /// 难度：简单
    /// 描述：给定一个二叉树，返回其节点值自底向上的层次遍历。 （即按从叶子节点所在层到根节点所在的层，逐层从左向右遍历）
    /// </summary>
    public class LevelOrderBottom
    {
        public IList<IList<int>> Excution1(IsSameTree.TreeNode root)
        {
            var result = new List<IList<int>>();
            ExcutionPrivate(root, result, 0);
            result.Reverse();
            return result;
        }

        private void ExcutionPrivate(IsSameTree.TreeNode root, List<IList<int>> list, int level)
        {
            if (root == null) return;

            while (list.Count <= level)
            {
                list.Add(new List<int>());
            }

            list[level].Add(root.val);

            level++;
            ExcutionPrivate(root.left, list, level);
            ExcutionPrivate(root.right, list, level);
        }
    }
}
