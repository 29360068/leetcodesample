using System.Collections.Generic;

namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：13. 罗马数字转整数
    /// 难度：简单
    /// 描述：罗马数字包含以下七种字符: I， V， X， L，C，D 和 M。……
    /// </summary>
    public class RomanToInt
    {
        /// <summary>
        /// 业务思路
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int Excution1(string s)
        {
            var map = new Dictionary<char, int>()
            {
                {'I',1 },
                {'V',5 },
                {'X',10 },
                {'L',50 },
                {'C',100 },
                {'D',500 },
                {'M',1000 }
            };

            int total = 0;
            char firstChar, secondChar;
            for (int i = 0; i < s.Length; i++)
            {
                firstChar = s[i];
                var first = map[firstChar];

                if (i < s.Length - 1)
                {
                    secondChar = s[i + 1];
                    var second = map[secondChar];

                    if ((firstChar == 'I' && (secondChar == 'V' || secondChar == 'X')) ||
                        (firstChar == 'X' && (secondChar == 'L' || secondChar == 'C')) ||
                        (firstChar == 'C' && (secondChar == 'D' || secondChar == 'M')))
                    {
                        first = second - first;

                        i++;
                    }
                }

                total += first;
            }

            return total;
        }

        /// <summary>
        /// 优化思路
        /// 主要是将char类型的相等判断转成了基于数值的大小的判断，这样更快
        /// 另外，也减少了char字符的转存以及构造
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int Excution2(string s)
        {
            var charValueMapping = new Dictionary<char, int>()
            {
                {'I',1 },
                {'V',5 },
                {'X',10 },
                {'L',50 },
                {'C',100 },
                {'D',500 },
                {'M',1000 }
            };

            int total = 0;
            int preValue = charValueMapping[s[0]];

            for (int i = 1; i < s.Length; i++)
            {
                int curValue = charValueMapping[s[i]];
                if(preValue < curValue)
                {
                    total -= preValue;
                }
                else
                {
                    total += preValue;
                }

                preValue = curValue;
            }

            return total + preValue;
        }
    }
}
