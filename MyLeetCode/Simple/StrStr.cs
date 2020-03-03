using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：28. 实现 strStr()
    /// 难度：简单
    /// 描述：给定一个 haystack 字符串和一个 needle 字符串，在 haystack 字符串中找出 needle 字符串出现的第一个位置 (从0开始)。如果不存在，则返回  -1。
    /// </summary>
    public class StrStr
    {
        public int Excution1(string haystack, string needle)
        {
            if (string.IsNullOrWhiteSpace(needle))
            {
                return 0;
            }

            for (int h = 0; h <= haystack.Length - needle.Length; h++)
            {
                if (haystack[h] == needle[0])
                {
                    var sh = h + 1;
                    var n = 1;
                    for (; n < needle.Length; n++, sh++)
                    {
                        if (haystack[sh] != needle[n])
                        {
                            break;
                        }
                    }

                    if (n == needle.Length)
                    {
                        return h;
                    }
                }
            }

            return -1;
        }
    }
}
