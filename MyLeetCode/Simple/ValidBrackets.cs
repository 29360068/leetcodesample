using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：20. 有效的括号
    /// 难度：简单
    /// 描述：给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串，判断字符串是否有效。
    /// </summary>
    public class ValidBrackets
    {
        public bool Excution1(string s)
        {
            if(string.IsNullOrWhiteSpace(s))
            {
                return true;
            }

            //奇数个肯定无效
            if( s.Length % 2 > 0)
            {
                return false;
            }

            var mapping = new Dictionary<char, char>
            {
                {'(',')' },
                {'{','}' },
                {'[',']' },
            };

            var sts = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if(sts.Count > 0 && mapping[sts.Peek()] == s[i])
                {
                    sts.Pop();
                }
                else
                {
                    if (mapping.ContainsKey(s[i]) == false)
                    {
                        return false;
                    }
                    else
                    {
                        sts.Push(s[i]);
                    }
                }
            }

            return sts.Count == 0;
        }
    }
}
