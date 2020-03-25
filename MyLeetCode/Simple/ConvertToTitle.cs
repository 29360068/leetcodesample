using System;

namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：168. Excel表列名称
    /// 难度：简单
    /// 描述：给定一个正整数，返回它在 Excel 表中相对应的列名称。
    /// </summary>
    public class ConvertToTitle
    {
        public string Excution1(int n)
        {
            if (n <= 0) return string.Empty;

            var result = string.Empty;

            do
            {
                var y = n % 26;
                n = n / 26;
                if (y > 0)
                {
                    result = (char)((y - 1) + 'A') + result;
                }
                else
                {
                    result = 'Z' + result;
                    n--;
                }

            } while (n > 0);

            return result;
        }
    }
}
