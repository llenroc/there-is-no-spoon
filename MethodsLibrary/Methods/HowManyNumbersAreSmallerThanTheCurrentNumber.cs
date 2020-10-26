namespace MethodsLibrary
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class HowManyNumbersAreSmallerThanTheCurrentNumber
    {
        public int[] SmallerNumbersThanCurrentBruteForce(int[] nums)
        {
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j == i)
                    {
                        continue;
                    }
                    if (nums[j] < nums[i])
                    {
                        result[i]++;
                    }
                }
            }
            return result;
        }

        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] freq = new int[101];
            for (int i = 0; i < nums.Length; i++)
            {
                freq[nums[i]]++;
            }

            for (int i = 1; i < freq.Length; i++)
            {
                freq[i] = freq[i] + freq[i - 1];
            }

            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0) //careful with 0, 
                {
                    result[i] = freq[nums[i] - 1];
                }
                //result[i] = nums[i] == 0 ? 0 : freq[nums[i] - 1];
            }
            return result;
        }

        [TestMethod]
        public void SmallerNumbersThanCurrent()
        {
            int[] input = new int[] { 6, 5, 4, 8 };
            //int[] input = new int[] { 7, 7, 7, 7 };
            var output = SmallerNumbersThanCurrent(input);
            foreach (var n in output)
            {
                System.Console.Write(n + " ");
            }
        }
    }
}
