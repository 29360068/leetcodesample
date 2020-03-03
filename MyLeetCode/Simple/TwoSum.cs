using System.Collections.Generic;

namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：1. 两数之和
    /// 难度：简单
    /// 描述：给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。
    /// </summary>
    public class TwoSum
    {
        public int[] Excution1(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>() { { nums[0], 0 } };
            for (int i = 1; i < nums.Length; i++)
            {
                var exp = target - nums[i];
                if (dic.TryGetValue(exp, out var val))
                {
                    return new int[2] { val, i };
                }
                else
                {
                    dic.TryAdd(nums[i], i);
                }
            }
            return new int[2] { 0, 0 };
        }
    }
}
