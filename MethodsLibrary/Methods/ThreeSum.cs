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

            IList<IList<int>> resultList = new List<IList<int>>();

            HashSet<int> set = new HashSet<int>();

            for (int index1 = 0; index1 < nums.Length; index1++)
            {
                int first = nums[index1];
                for (int index2 = index1 + 1; index2 < nums.Length; index2++)
                {
                    int second = nums[index2];
                    if (set.Contains(first - second))
                    {
                        IList<int> solutionList = new List<int>();
                        solutionList.Add(first);
                        solutionList.Add(second);
                        solutionList.Add(first - second);
                        resultList.Add(solutionList);
                    }
                    set.Add(second);
                }
                set.Clear();
            }

            return resultList;
        }
    }
}