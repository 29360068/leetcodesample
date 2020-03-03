namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：35. 搜索插入位置
    /// 难度：简单
    /// 描述：给定一个排序数组和一个目标值，在数组中找到目标值，并返回其索引。如果目标值不存在于数组中，返回它将会被按顺序插入的位置。
    /// </summary>
    public class SearchInsert
    {
        public int Excution1(int[] nums, int target)
        {
            if (nums.Length == 0 || nums[0] >= target) return 0;
            if (nums[nums.Length - 1] < target) return nums.Length;
            if (nums[nums.Length - 1] == target) return nums.Length - 1;

            var position = FindPosition(nums, 0, nums.Length - 1, target);

            if(nums[position] >= target)
            {
                return position;
            }
            else
            {
                return position + 1;
            }
        }

        private int FindPosition(int[] nums, int startIndex, int endIndex , int target)
        {
            if(endIndex - startIndex <= 1)
            {
                if (nums[startIndex] == target) return startIndex;
                return endIndex;
            }
            else
            {
                var half = (endIndex - startIndex) / 2 + startIndex;

                if (nums[half] == target)
                {
                    return half;
                }
                else if (nums[half] > target)
                {
                    return FindPosition(nums, startIndex, half, target);
                }
                else
                {
                    return FindPosition(nums, half, endIndex, target);
                }
            }
        }
    }
}
