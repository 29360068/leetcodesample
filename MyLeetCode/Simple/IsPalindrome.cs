﻿namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：9. 回文数
    /// 难度：简单
    /// 描述：判断一个整数是否是回文数。回文数是指正序（从左向右）和倒序（从右向左）读都是一样的整数。
    /// </summary>
    public class IsPalindrome
    {
        public bool Excution1(int x)
        {
            if (x < 0)
            {
                return false;
            }

            if (x / 10 == 0)
            {
                return true;
            }

            if (x % 10 == 0)
            {
                return false;
            }

            int revertedNumber = 0;
            while (x > revertedNumber)
            {
                revertedNumber = revertedNumber * 10 + x % 10;
                x /= 10;
            }

            // 当数字长度为奇数时，我们可以通过 revertedNumber/10 去除处于中位的数字。
            // 例如，当输入为 12321 时，在 while 循环的末尾我们可以得到 x = 12，revertedNumber = 123，
            // 由于处于中位的数字不影响回文（它总是与自己相等），所以我们可以简单地将其去除。
            return x == revertedNumber || x == revertedNumber / 10;
        }
    }
}

