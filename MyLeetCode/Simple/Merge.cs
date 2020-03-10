using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：88. 合并两个有序数组
    /// 难度：简单
    /// 描述：给你两个有序整数数组 nums1 和 nums2，请你将 nums2 合并到 nums1 中，使 num1 成为一个有序数组。
    /// </summary>
    public class Merge
    {
        public void Excution1(int[] nums1, int m, int[] nums2, int n)
        {
            int index1 = m - 1, index2 = n - 1, totalLength = m + n;

            for (int i = totalLength - 1; i >= 0; i--)
            {
                nums1[i] = (index1 >= 0 && (index2 < 0 || nums1[index1] >= nums2[index2])) ? nums1[index1--] : nums2[index2--];
            }
        }
    }
}
