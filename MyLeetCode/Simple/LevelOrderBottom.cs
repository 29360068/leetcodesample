using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Simple
{
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
