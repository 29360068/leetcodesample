namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：38. 外观数列
    /// 难度：简单
    /// 描述：「外观数列」是一个整数序列，从数字 1 开始，序列中的每一项都是对前一项的描述
    /// </summary>
    public class CountAndSay
    {
        public string Excution1(int n)
        {
            if(n < 0 || n > 30)
            {
                return string.Empty;
            }

            var root = "1";
            while (n > 1)
            {
                var tmpTotal = string.Empty;
                var tmpChar = root[0];
                var tmpCount = 1;
                for (int i = 1; i < root.Length; i++)
                {
                    if(tmpChar == root[i])
                    {
                        tmpCount++;
                    }
                    else
                    {
                        tmpTotal += tmpCount + tmpChar.ToString();
                        tmpChar = root[i];
                        tmpCount = 1;
                    }
                }
                
                root = tmpTotal + tmpCount + tmpChar.ToString();

                n--;
            }

            return root;
        }
    }
}
