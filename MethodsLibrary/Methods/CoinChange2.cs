using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodsLibrary.Methods
{
    public class CoinChange2
    {
        public static int Change(int amount, int[] coins)
        {
            if ((coins.Length <= 0) || (coins == null))
            {
                if(amount == 0) return 1;
                else return 0;
            }
            Array.Sort(coins);
            int[] combination = new int[coins.Length];
            IList<int[]> combinations = new List<int[]>();
            huaqian(amount, coins, amount, combination, combinations);
            //foreach(var combo in combinations)
            //{
            //    Console.WriteLine("final combos: " + string.Join(",", combo));
            //}
            return combinations.Count;
        }

        public static void huaqian(int amount, int[] coins, int sum, int[] combination, IList<int[]> combinations)
        {
            if (sum < 0)
            {
                return;
            }
            if (sum == 0)
            {
                if(!hasCombo(combinations, combination))
                {
                    combinations.Add(combination.ToArray());
                }                
                return;
            }

            for (int i = coins.Length-1; i >= 0; i--)
            {
                combination[i]++;
                sum = sum - coins[i];                
                huaqian(amount, coins, sum, combination, combinations);
                combination[i]--;
                sum = sum + coins[i];
            }
        }

        private static bool hasCombo(IList<int[]> combinations, int[] combination)
        {
            bool isEqual = false;
            foreach (var combo in combinations)
            {
                isEqual = Enumerable.SequenceEqual(combo, combination);
                if (isEqual)
                {
                    return true;
                }
            }
            return false;
        }
    }
}