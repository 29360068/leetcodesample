using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：26. 删除排序数组中的重复项
    /// 难度：简单
    /// 描述：给定一个排序数组，你需要在原地删除重复出现的元素，使得每个元素只出现一次，返回移除后数组的新长度。
    /// </summary>
    public class RemoveDuplicates
    {
        public int Excution1(int[] nums)
        {
            if (nums.Length == 0 || nums.Length == 1)
            {
                return nums.Length;
            }

            int slowIndex = 0;
            for (int fastIndex = 1; fastIndex < nums.Length; fastIndex++)
            {
                if(nums[slowIndex] != nums[fastIndex])
                {
                    slowIndex++;
                    nums[slowIndex] = nums[fastIndex];
                }
            }
            return slowIndex + 1;
        }
    }
}
