using System.Collections.Generic;

namespace MyLeetCode.Simple
{
        /// <summary>
    /// 序号：169. 多数元素
    /// 难度：简单
    /// 描述：给定一个大小为 n 的数组，找到其中的多数元素。多数元素是指在数组中出现次数大于 ⌊ n/2 ⌋ 的元素。
    /// </summary>
    public class MajorityElement
    {
        public int Excution1(int[] nums)
        {
            var dic = new Dictionary<int, int>();

            foreach (var n in nums)
            {
                if (dic.ContainsKey(n) == false)
                {
                    dic.Add(n, 0);
                }

                dic[n]++;
            }

            int max = 0, r = 0;
            foreach (var i in dic)
            {
                if (i.Value > max)
                {
                    max = i.Value;
                    r = i.Key;
                }
            }

            return r;
        }
    }
}
