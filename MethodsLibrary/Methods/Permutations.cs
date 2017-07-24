using System.Collections.Generic;

namespace MethodsLibrary.Methods
{
    public class Permutations
    {
        public static IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> permutations = new List<IList<int>>();
            if ((nums == null) || (nums.Length == 0))
            {
                return permutations;
            }
            IList<int> permutation = new List<int>();

            Find(permutations, permutation, nums);

            return permutations;
        }

        private static void Find(IList<IList<int>> permutations, IList<int> permutation, int[] nums)
        {
            if (permutation.Count == nums.Length)
            {
                permutations.Add(new List<int>(permutation));
                return;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (permutation.Contains(nums[i]))
                {
                    continue;
                }
                permutation.Add(nums[i]);
                Find(permutations, permutation, nums);
                permutation.RemoveAt(permutation.Count - 1);
            }
        }
    }
}