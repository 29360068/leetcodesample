using System.Collections.Generic;

namespace MyLeetCodeTests
{
    public static class Common
    {
        public static bool AreEqual(this IList<IList<int>> expect, IList<IList<int>> target)
        {
            for (int i = 0; i < expect.Count; i++)
            {
                if (i >= target.Count) return false;

                for (int j = 0; j < expect[i].Count; j++)
                {
                    if (j >= target[i].Count) return false;

                    if (expect[i][j] != target[i][j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool AreEqual(this IList<int> l1, IList<int> l2)
        {
            if (l1.Count != l2.Count) return true;
            for (int i = 0; i < l1.Count; i++)
            {
                if (l1[i] != l2[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AreEqual(this int [] nums1, int[] nums2)
        {
            if(nums1.Length == nums2.Length)
            {
                for (int i = 0; i < nums1.Length; i++)
                {
                    if(nums1[i] != nums2[i])
                    {
                        break;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
