using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：119. 杨辉三角 II
    /// 难度：简单
    /// 描述：给定一个非负索引 k，其中 k ≤ 33，返回杨辉三角的第 k 行。
    /// </summary>
    public class YangHui2
    {
        public IList<int> GetRow(int rowIndex)
        {
            var list = new int[rowIndex + 1];
            if (rowIndex >= 0)
            {
                list[0] = 1;
                if (rowIndex >= 1)
                {
                    list[1] = 1;

                    if (rowIndex >= 2)
                    {
                        while (list[rowIndex] == 0)
                        {
                            var index = 1;
                            var pre = list[0];
                            while (list[index] != 0)
                            {
                                var val = pre + list[index];
                                pre = list[index];
                                list[index] = val;

                                index++;
                            }
                            list[index] = 1;
                        }
                    }
                }
            }

            return list;

        }
    }
}
