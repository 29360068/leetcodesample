using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：189. 旋转数组
    /// 难度：简单
    /// 描述：给定一个数组，将数组中的元素向右移动 k 个位置，其中 k 是非负数。
    /// </summary>
    public class Rotate
    {
        public void Excution(int[] nums, int k)
        {
            var count = nums.Length;
            k = k % nums.Length;
            if (k > 0)
            {
                var startIndex = -1;
                int targetIndex = startIndex, tmp = 0;
                while (count > 0)
                {
                    if (targetIndex == startIndex)
                    {
                        startIndex++;
                        targetIndex = startIndex;
                        tmp = nums[startIndex];
                    }

                    targetIndex = (k + targetIndex) % nums.Length;
                    var t = nums[targetIndex];
                    nums[targetIndex] = tmp;
                    tmp = t;
      
                    count--;
                }
            }
        }
    }
}
