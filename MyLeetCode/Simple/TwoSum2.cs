namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：167. 两数之和 II - 输入有序数组
    /// 难度：简单
    /// 描述：给定一个已按照升序排列 的有序数组，找到两个数使得它们相加之和等于目标数。
    /// </summary>
    public class TwoSum2
    {
        public int[] Excution1(int[] numbers, int target)
        {
            int start = 0, end = numbers.Length - 1;

            int result;
            while ((result = numbers[start] + numbers[end]) != target)
            {
                if (result > target)
                {
                    end--;
                }
                else
                {
                    start++;
                }
            }

            return new[] {start + 1, end + 1};
        }
    }
}
