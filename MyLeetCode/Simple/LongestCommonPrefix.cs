namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：14. 最长公共前缀
    /// 难度：简单
    /// 描述：编写一个函数来查找字符串数组中的最长公共前缀。如果不存在公共前缀，返回空字符串 ""。
    /// </summary>
    public class LongestCommonPrefix
    {
        public string Excution1(string[] strs)
        {
            if (strs.Length == 0) return string.Empty;

            var shortestLength = int.MaxValue;
            foreach (var str in strs)
            {
                if (string.IsNullOrWhiteSpace(str))
                {
                    return string.Empty;
                }
                else
                {
                    if (shortestLength > str.Length)
                    {
                        shortestLength = str.Length;
                    }
                }
            }

            var prefix = string.Empty;
            for (int i = 0; i < shortestLength; i++)
            {
                if (FindEqualChar(strs, i, out var c))
                {
                    prefix += c;
                }
                else
                {
                    break;
                }
            }

            return prefix;
        }

        private bool FindEqualChar(string[] strs, int position, out char c)
        {
            c = strs[0][position];

            for (int i = 1; i < strs.Length; i++)
            {
                if (strs[i][position] != c)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
