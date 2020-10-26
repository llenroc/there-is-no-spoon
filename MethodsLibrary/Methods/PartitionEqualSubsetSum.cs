namespace MethodsLibrary.Methods
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class PartitionEqualSubsetSum
    {
        public bool CanPartition(int[] nums)
        {
            int len = nums.Length;
            if (len < 2)
            {
                return false;
            }

            int sum = 0, maxNum = 0;
            foreach (int num in nums)
            {
                sum += num;
                maxNum = Math.Max(maxNum, num);
            }

            // 特判：如果是奇数，就不符合要求
            if ((sum & 1) == 1)
            {
                return false;
            }

            int target = sum / 2;
            // If the max value of the array is greater than the target, then it's false
            if (maxNum > target)
            {
                return false;
            }
            // 创建二维状态数组，行：物品索引，列：容量（包括 0）
            bool[,] dp = new bool[len, target + 1];

            dp[0, 0] = true;

            if (nums[0] == target)
            {
                dp[0, nums[0]] = true;
            }

            // 再填表格后面几行
            for (int i = 1; i < len; i++)
            {
                for (int j = 0; j <= target; j++)
                {
                    // 直接从上一行先把结果抄下来，然后再修正
                    dp[i, j] = dp[i - 1, j];

                    if (nums[i] == j)
                    {
                        dp[i, j] = true;
                        continue;
                    }
                    if (nums[i] < j)
                    {
                        dp[i, j] = dp[i - 1, j] || dp[i - 1, j - nums[i]];
                    }
                }
                // 由于状态转移方程的特殊性，提前结束，可以认为是剪枝操作
                //观察状态转移方程，or 的结果只要为真，表格 这一列 下面所有的值都为真。因此在填表的时候，只要表格的最后一列是 true，代码就可以结束，直接返回 true。
                if (dp[i, target])
                {
                    return true;
                }
            }
            return dp[len - 1, target];
        }

        public bool canPartitionOfficial(int[] nums)
        {
            int n = nums.Length;
            if (n < 2)
            {
                return false;
            }
            int sum = 0, maxNum = 0;
            foreach (int num in nums)
            {
                sum += num;
                maxNum = Math.Max(maxNum, num);
            }
            if (sum % 2 != 0)
            {
                return false;
            }
            int target = sum / 2;
            if (maxNum > target)
            {
                return false;
            }
            bool[,] dp = new bool[n, target + 1];
            for (int i = 0; i < n; i++)
            {
                dp[i, 0] = true;
            }
            dp[0, nums[0]] = true;
            for (int i = 1; i < n; i++)
            {
                int num = nums[i];
                for (int j = 1; j <= target; j++)
                {
                    if (j >= num)
                    {
                        dp[i, j] = dp[i - 1, j] | dp[i - 1, j - num];
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                }
            }
            return dp[n - 1, target];
        }

        public bool canPartitionOfficialOptmize(int[] nums)
        {
            int n = nums.Length;
            if (n < 2)
            {
                return false;
            }
            int sum = 0, maxNum = 0;
            foreach (int num in nums)
            {
                sum += num;
                maxNum = Math.Max(maxNum, num);
            }
            if (sum % 2 != 0)
            {
                return false;
            }
            int target = sum / 2;
            if (maxNum > target)
            {
                return false;
            }
            bool[] dp = new bool[target + 1];
            dp[0] = true;
            for (int i = 0; i < n; i++)
            {
                int num = nums[i];
                for (int j = target; j >= num; --j)
                {
                    dp[j] |= dp[j - num];
                }
            }
            return dp[target];
        }


        [TestMethod]
        public void CanPartitionTest()
        {

        }
    }
}
