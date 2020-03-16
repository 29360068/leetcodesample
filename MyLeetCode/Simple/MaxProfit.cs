using System;

namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：121. 买卖股票的最佳时机
    /// 难度：简单
    /// 描述：给定一个数组，它的第 i 个元素是一支给定股票第 i 天的价格。
    /// </summary>
    public class MaxProfit
    {
        public int Excution1(int[] prices)
        {
            var maxResult = 0;

            if (prices.Length > 1)
            {
                for (var i = 0; i < prices.Length - 1; i++)
                {
                    for (var j = i + 1; j < prices.Length; j++)
                    {
                        if (prices[j] > prices[i])
                        {
                            maxResult = Math.Max(prices[j] - prices[i], maxResult);
                        }
                    }
                }
            }

            return maxResult;
        }

        public int Excution2(int[] prices)
        {
            var maxResult = 0;

            if (prices.Length > 1)
            {
                var smallest = prices[0];
                for (var i = 1; i < prices.Length; i++)
                {
                    maxResult = Math.Max(prices[i] - smallest, maxResult);
                    smallest = Math.Min(prices[i], smallest);
                }
            }

            return maxResult;
        }
    }
}
