using System.Collections.Generic;

namespace MethodsLibrary.Methods
{
    public static class TwoSum
    {
        /// <summary>
        /// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
        /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// </summary>
        /// <param name="nums"> Array of integers </param>
        /// <param name="target"> Target value as the sum of two numbers in the array </param>
        /// <returns> Array of indices of the two numbers such that they add up to the target </returns>
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
                    if (!dict.ContainsKey(nums[i])) // C# Dictionary can't handle duplicate keys or null keys like HashMap in Java
                        dict.Add(nums[i], i);
                }
            }
            return result;
        }
    }
}
