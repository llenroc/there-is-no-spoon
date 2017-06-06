namespace MethodsLibrary.Methods
{
    public class MaxProfitII
    {
        public static int maxProfitII(int[] prices)
        {
            //look for the price that's greater
            if ((prices == null) || (prices.Length == 0))
            {
                return 0;
            }
            int profit = 0;
            int min = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    profit += prices[i] - prices[i - 1];
                }
            }
            return profit;
        }
    }
}