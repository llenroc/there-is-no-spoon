using System;
using System.Collections.Generic;

namespace MethodsLibrary.Methods
{
    public class ThreeSum
    {
        /// <summary>
        /// Given an array S of n integers, are there elements a, b, c in S such that a + b + c = 0? 
        /// Find all unique triplets in the array which gives the sum of zero.
        /// Note: The solution set must not contain duplicate triplets.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> threeSum(int[] nums)
        {
            if ((nums == null) && (nums.Length == 0))
            {
                return null;
            }
            Array.Sort(nums);
            IList<IList<int>> resultList = new List<IList<int>>();

            for (int index1 = 0; index1 < nums.Length-2; index1++)
            {
                // Skip the same numbers
                if(index1 > 0 && nums[index1] == nums[index1-1])
                {
                    continue;
                }
                int index2 = index1 + 1;
                int index3 = nums.Length - 1;
                while (index2 < index3)
                {
                    int first = nums[index1];
                    int second = nums[index2];
                    int third = nums[index3];

                    if (first + second + third == 0)
                    {
                        IList<int> solution = new List<int>();
                        solution.Add(first);
                        solution.Add(second);
                        solution.Add(third);
                        resultList.Add(solution);
                        index2++;
                        index3--;
                        while (index2 < index3 && nums[index2] == nums[index2 - 1]) index2++;  // skip same result
                        while (index2 < index3 && nums[index3] == nums[index3 + 1]) index3--;  // skip same result
                    }
                    else if(first + second + third <0 )
                    {
                        index2++;
                    }
                    else
                    {
                        index3--;
                    }
                }
            }            
            return resultList;
        }
    }
}