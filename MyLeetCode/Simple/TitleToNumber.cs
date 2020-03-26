using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：171. Excel表列序号
    /// 难度：简单
    /// 描述：给定一个Excel表格中的列名称，返回其相应的列序号。
    /// </summary>
    public class TitleToNumber
    {
        public int Excution1(string s)
        {
            var total = 0;
            for (int i = 0, j = s.Length - 1; i < s.Length; i++, j--)
            {
                total += (s[j] - 'A' + 1) * (int)Math.Pow(26, i);
            }
            return total;
        }
    }
}
