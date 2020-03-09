using System.Collections.Generic;

namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：70. 爬楼梯
    /// 难度：简单
    /// 描述：假设你正在爬楼梯。需要 n 阶你才能到达楼顶。 每次你可以爬 1 或 2 个台阶。你有多少种不同的方法可以爬到楼顶呢？
    /// </summary>
    public class ClimbStairs
    {
        private Dictionary<int, int> dic = new Dictionary<int, int>();

        public int Excution1(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                var firstIndex = n - 1;
                if (dic.TryGetValue(firstIndex, out var first) == false)
                {
                    first = Excution1(firstIndex);
                    dic.Add(firstIndex, first);
                }

                var secondIndex = n - 2;
                if (dic.TryGetValue(secondIndex, out var second) == false)
                {
                    second = Excution1(secondIndex);
                    dic.Add(secondIndex, second);
                }

                return first + second;
            }
        }
    }
}
