using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：58. 最后一个单词的长度
    /// 难度：简单
    /// 描述：给定一个仅包含大小写字母和空格 ' ' 的字符串 s，返回其最后一个单词的长度。
    /// </summary>
    public class LengthOfLastWord
    {
        public int Excution1(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return 0;

            var firstNotEmptyIndex = s.Length;
            var i = s.Length - 1;
            for (; i >= 0; i--)
            {
                if(s[i] == ' ')
                {
                    if(firstNotEmptyIndex != s.Length)
                    {
                        break;
                    }
                }
                else
                {
                    if(firstNotEmptyIndex == s.Length)
                    {
                        firstNotEmptyIndex = i;
                    }
                }
            }

            return firstNotEmptyIndex - i;
        }

        public int Excution2(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return 0;

            var i = s.Length - 1;
            var count = 0;
            for (; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    count++;
                }
                else if(count > 0)
                {
                    break;
                }
            }

            return count;
        }
    }
}
