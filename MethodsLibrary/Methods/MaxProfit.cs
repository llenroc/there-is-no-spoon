using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsLibrary.Methods
{
    public class MaxProfit
    {
        //keep track of the min value 
        //and calculate the max profit 
        public static int maxProfit(int[] prices)
        {
            if(prices == null || prices.Length==0)
            {
                return 0;
            }
            int maxCur = 0, maxSoFar = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                maxCur = Math.Max(0, maxCur += prices[i] - prices[i - 1]);
                maxSoFar = Math.Max(maxCur, maxSoFar);
            }
            return maxSoFar;
        }

        public static int maxProfitG(int[] prices)
        {
            if (prices == null || prices.Length == 0)
            {
                return 0;
            }
            int minSoFar = prices[0], profit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if(prices[i] > minSoFar)
                {
                    profit = Math.Max(profit, prices[i]-minSoFar);
                }
                else
                {
                    minSoFar = prices[i];
                }
            }
            return profit;
        }

        public static int maxProfitGG(int[] prices)
        {
            if (prices == null || prices.Length == 0)
            {
                return 0;
            }
            int min = int.MaxValue;
            int profit = 0;

            foreach(int num in prices)
            {
                min = num<min ? num : min;
                profit = num - min>profit  ? num - min : profit;
            }
            return profit;
        }
    }
}
