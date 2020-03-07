using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：67. 二进制求和
    /// 难度：简单
    /// 描述：给定两个二进制字符串，返回他们的和（用二进制表示）。
    /// </summary>
    public class AddBinary
    {
        private Stack<char> _result = new Stack<char>();

        public string Excution1(string a, string b)
        {
            AddBinaryPrivate(ref a, ref b, 1, '0');

            var result = new StringBuilder();
            while(_result.TryPop(out var item))
            {
                result.Append(item);
            }

            return result.ToString();
        }

        private void AddBinaryPrivate(ref string a, ref string b, int revertIndex, char add)
        {
            var aIndex = a.Length - revertIndex;
            var bIndex = b.Length - revertIndex;

            var aChar = aIndex >= 0 ? a[aIndex] : '0';
            var bChar = bIndex >= 0 ? b[bIndex] : '0';

            var oneCount = 0;
            if (aChar == '1') oneCount++;
            if (bChar == '1') oneCount++;
            if (add == '1') oneCount++;

            if(aIndex < 0 && bIndex <0 && oneCount == 0)
            {
                return;
            }

            char sumResult = '0';
            char addResult = '0';
            switch(oneCount)
            {
                case 1:
                    sumResult = '1';
                    break;
                case 2:
                    addResult = '1';
                    break;
                case 3:
                    sumResult = '1';
                    addResult = '1';
                    break;
            }

            _result.Push(sumResult);
            AddBinaryPrivate(ref a,ref b, ++revertIndex, addResult);
        }
    }
}
