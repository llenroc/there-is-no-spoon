using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsLibrary.Methods
{
    public class LongestConsecutiveSequence
    {
        /*
         * Given an unsorted array of integers, find the length of the longest consecutive elements sequence.
         * For example, Given [100, 4, 200, 1, 3, 2], 
         * The longest consecutive elements sequence is [1, 2, 3, 4]. Return its length: 4.  
         */
        public static int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0 || nums == null) return 0;
            if (nums.Length == 1) return 1;
            int maxLength = 1;
            int length = 1;
            Array.Sort(nums);

            int i = 1;
            while (i < nums.Length)
            {
                if(nums[i] == nums[i - 1])
                {
                    i++;
                    continue;
                }
                if(nums[i]-1 == nums[i-1])
                {
                    length++;
                    maxLength = Math.Max(length, maxLength);
                }
                else
                {
                    maxLength = Math.Max(length, maxLength);
                    length = 1;
                }
                i++;
            }
            return maxLength;
        }

        /// <summary>
        /// Best performance but I didn't write this :)
        /// Paste here for me to learn
        /// </summary>
        /// <param name="nums"> input int array </param>
        /// <returns> the length of the longest consecutive elements sequence </returns>
        public static int LongestConsecutiveDictionary(int[] nums)
        {
            IDictionary<int, int> map = new Dictionary<int, int>();
            int maxSeqLength = 0;

            foreach (int num in nums)
            {
                if (!map.ContainsKey(num))
                {
                    int left = 0, right = 0;
                    map.TryGetValue(num - 1, out left);
                    map.TryGetValue(num + 1, out right);

                    int sum = left + right + 1;
                    maxSeqLength = Math.Max(maxSeqLength, sum);
                    map.Add(num, sum);
                    map[num - left] = sum;
                    map[num + right] = sum;
                }
            }

            return maxSeqLength;
        }

        /// <summary>
        /// Better performance but I didn't write this :)
        /// Paste here for me to learn
        /// </summary>
        /// <param name="nums"> input int array </param>
        /// <returns> the length of the longest consecutive elements sequence </returns>
        public static int LongestConsecutiveHashSet(int[] nums)
        {
            HashSet<int> hashSet = new HashSet<int>(nums);
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (hashSet.Contains(nums[i]))
                {
                    int count = 1;
                    int next = nums[i] - 1;
                    hashSet.Remove(nums[i]);
                    while (hashSet.Contains(next))
                    {
                        hashSet.Remove(next);
                        next--;
                        count++;
                    }
                    next = nums[i] + 1;
                    while (hashSet.Contains(next))
                    {
                        hashSet.Remove(next);
                        next++;
                        count++;
                    }
                    max = Math.Max(max, count);
                }


            }
            return max;
        }
    }
}
