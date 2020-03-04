using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：53. 最大子序和
    /// 难度：简单
    /// 描述：给定一个整数数组 nums ，找到一个具有最大和的连续子数组（子数组最少包含一个元素），返回其最大和。
    /// </summary>
    public class MaxSubArray
    {
        public int Excution1(int[] nums)
        {
            if (nums.Length == 0) return 0;

            var biggest = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                var sumResult = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    sumResult += nums[j];

                    if(biggest <= sumResult)
                    {
                        biggest = sumResult;
                    }
                }
            }

            return biggest;
        }
    }
}
