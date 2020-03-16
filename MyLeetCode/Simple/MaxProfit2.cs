namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：122. 买卖股票的最佳时机 II
    /// 难度：简单
    /// 描述：给定一个数组，它的第 i 个元素是一支给定股票第 i 天的价格。
    /// </summary>
    public class MaxProfit2
    {
        /// <summary>
        /// 必须识别出来持续升高的曲线能够获取最大的利益
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int Excution1(int[] prices)
        {
            var result = 0;

            if (prices.Length > 1)
            {
                var segMin = prices[0];
                for (var i = 1; i < prices.Length; i++)
                {
                    if (prices[i] < prices[i - 1])
                    {
                        result += prices[i - 1] - segMin;
                        segMin = prices[i];
                    }
                }

                if (prices[prices.Length - 1] > segMin)
                {
                    result += prices[prices.Length - 1] - segMin;
                }
            }

            return result;
        }
    }
}
