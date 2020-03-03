namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：27. 移除元素
    /// 难度：简单
    /// 描述：给定一个数组 nums 和一个值 val，你需要原地移除所有数值等于 val 的元素，返回移除后数组的新长度。
    /// </summary>
    public class RemoveElement
    {
        public int Excution1(int[] nums, int val)
        {
            if(nums == null)
            {
                return 0;
            }
            else if(nums.Length == 1)
            {
                return nums[0] == val ? 0 : 1;
            }
            else
            {
                var slowIndex = -1;
                for (var fastIndex = 0; fastIndex < nums.Length; fastIndex++)
                {
                    if(nums[fastIndex] != val)
                    {
                        slowIndex++;
                        nums[slowIndex] = nums[fastIndex];
                    }
                }

                return slowIndex + 1;
            }
        }
    }
}
