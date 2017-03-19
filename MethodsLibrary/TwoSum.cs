using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsLibrary
{
    public static class TwoSum
    {
        public static int[] twoSum(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return null;
            }
            int[] result = new int[2];
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    result[0] = dict[target - nums[i]];
                    result[1] = i;
                }
                else
                {
                    if (!dict.ContainsKey(nums[i]))
                        dict.Add(nums[i], i);
                }
            }
            return result;
        }
    }
}
