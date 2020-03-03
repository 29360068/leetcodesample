using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：7. 整数反转
    /// 难度：简单
    /// 描述：给出一个 32 位的有符号整数，你需要将这个整数中每位上的数字进行反转。
    /// </summary>
    public class ReverseInt
    {
        public int Excution1(int x)
        {
            long y = 0;
            while (x != 0)
            {
                int m = x % 10;
                x = x / 10;
                y = y * 10 + m;
            }

            if (Int32.MinValue < y && y < Int32.MaxValue)
            {
                return (Int32)y;
            }

            return 0;
        }
    }
}
