using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：172. 阶乘后的零
    /// 难度：简单
    /// 描述：给定一个整数 n，返回 n! 结果尾数中零的数量。
    /// </summary>
    public class TrailingZeroes
    {
        public int Excution1(int n)
        {
            var p = 0;
            while (n >= 5)
            {
                p += n / 5;
                n = n / 5;
            }

            return p;
        }
    }
}
