using System.Collections.Generic;

namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：125. 验证回文串
    /// 难度：简单
    /// 描述：给定一个字符串，验证它是否是回文串，只考虑字母和数字字符，可以忽略字母的大小写。
    /// </summary>
    public class IsPalindrome125
    {
        public bool Excution2(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return true;

            int iStart = 0, iEnd = s.Length - 1;

            while (iStart < iEnd)
            {
                if (char.IsLetterOrDigit(s[iStart]) == false)
                {
                    iStart++;
                    continue;
                }

                if (char.IsLetterOrDigit(s[iEnd]) == false)
                {
                    iEnd--;
                    continue;
                }

                if (char.ToLower(s[iStart]) != char.ToLower(s[iEnd]))
                {
                    return false;
                }

                iStart++;
                iEnd--;
            }

            return true;
        }

        public bool Excution1(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return true;

            var valideDic = new Dictionary<char, char>
            {
                {'a', 'a'},
                {'b', 'b'},
                {'c', 'c'},
                {'d', 'd'},
                {'e', 'e'},
                {'f', 'f'},
                {'g', 'g'},
                {'h', 'h'},
                {'i', 'i'},
                {'j', 'j'},
                {'k', 'k'},
                {'l', 'l'},
                {'m', 'm'},
                {'n', 'n'},
                {'o', 'o'},
                {'p', 'p'},
                {'q', 'q'},
                {'r', 'r'},
                {'s', 's'},
                {'t', 't'},
                {'u', 'u'},
                {'v', 'v'},
                {'w', 'w'},
                {'x', 'x'},
                {'y', 'y'},
                {'z', 'z'},
                {'A', 'a'},
                {'B', 'b'},
                {'C', 'c'},
                {'D', 'd'},
                {'E', 'e'},
                {'F', 'f'},
                {'G', 'g'},
                {'H', 'h'},
                {'I', 'i'},
                {'J', 'j'},
                {'K', 'k'},
                {'L', 'l'},
                {'M', 'm'},
                {'N', 'n'},
                {'O', 'o'},
                {'P', 'p'},
                {'Q', 'q'},
                {'R', 'r'},
                {'S', 's'},
                {'T', 't'},
                {'U', 'u'},
                {'V', 'v'},
                {'W', 'w'},
                {'X', 'x'},
                {'Y', 'y'},
                {'Z', 'z'},
                {'1', '1'},
                {'2', '2'},
                {'3', '3'},
                {'4', '4'},
                {'5', '5'},
                {'6', '6'},
                {'7', '7'},
                {'8', '8'},
                {'9', '9'},
                {'0', '0'}
            };
            
            int iStart = 0, iEnd = s.Length - 1;

            while (iStart < iEnd)
            {
                if (valideDic.ContainsKey(s[iStart]) == false)
                {
                    iStart++;
                    continue;
                }

                if (valideDic.ContainsKey(s[iEnd]) == false)
                {
                    iEnd--;
                    continue;
                }

                if (valideDic[s[iStart]] != valideDic[s[iEnd]])
                {
                    return false;
                }

                iStart++;
                iEnd--;
            }

            return true;
        }
    }
}
