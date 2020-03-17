using System.Collections.Generic;
using System.Linq;

namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：136. 只出现一次的数字
    /// 难度：简单
    /// 描述：给定一个非空整数数组，除了某个元素只出现一次以外，其余每个元素均出现两次。找出那个只出现了一次的元素。
    /// </summary>
    public class SingleNumber
    {
        public int Excution1(int[] nums)
        {
            var set = new HashSet<int>();
            foreach (var t in nums)
            {
                if (set.Contains(t))
                {
                    set.Remove(t);
                }
                else
                {
                    set.Add(t);
                }
            }

            return set.First();
        }
    }
}
