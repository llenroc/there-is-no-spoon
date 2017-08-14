using System;
using System.Collections.Generic;

namespace MethodsLibrary.Methods
{
    public class SlidingWindowMaximum
    {
        //[1,3,-1,-3,5,3,6,7] 3
        public static int[] MaxSlidingWindow(int[] nums, int k)
        {
            int[] result = new int[nums.Length - k + 1];

            if (nums.Length == 0 || nums == null || k<=0)
            {
                return nums; //new int[] { };
            }

            for (int i = 0; i <= nums.Length - k; i++)
            {
                int max = int.MinValue;

                int n = 0;
                while (n < k)
                {
                    max = Math.Max(max, nums[i+n]);
                    n++;
                }
                result[i] = max;
            }
            return result;
        }

        // Better performance, but not mine :(
        public int[] MaxSlidingWindowRevised(int[] nums, int k)
        {
            List<int> res = new List<int>();
            var list = new LinkedList<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (list.Count > 0 && list.First.Value == i - k)
                {
                    list.RemoveFirst();
                }
                while (list.Count > 0 && nums[list.Last.Value] < nums[i])
                {
                    list.RemoveLast();
                }
                list.AddLast(i);
                if (i >= k - 1)
                {
                    res.Add(nums[list.First.Value]);
                }
            }
            return res.ToArray();
        }
    }
}
