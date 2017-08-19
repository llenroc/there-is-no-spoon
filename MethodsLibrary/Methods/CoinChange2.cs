using System;
using System.Collections.Generic;

namespace MethodsLibrary.Methods
{
    public class CoinChange2
    {
        public static int Change(int amount, int[] coins)
        {
            if ((coins.Length <= 0) || (coins == null))
            {
                return 0;
            }
            int[] combination = new int[coins.Length];
            List<int[]> combinations = new List<int[]>();
            huaqian(amount, coins, amount, combination, combinations);
            return combinations.Count;
        }

        public static void huaqian(int amount, int[] coins, int sum, int[] combination, List<int[]> combinations)
        {
            if (sum < 0)
            {
                return;
            }
            if (sum == 0)
            {
                combinations.Add(combination);
                return;
            }

            for (int i = 0; i < coins.Length; i++)
            {
                combination[i]++;
                sum = sum - coins[i];
                huaqian(amount, coins, sum, combination, combinations);
                combination[i]--;
                sum = sum + coins[i];
            }
        }
    }
}