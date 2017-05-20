using System.Collections.Generic;

namespace MethodsLibrary.Methods
{
    public class ClosestNumbers
    {
        public static int[] closestNumbers(int T, int K, int[] A)
        {
            List<int> result = new List<int>();
            int start = 0;
            int end = A.Length-1;
            while (start <= end)
            {
                int calIndex = start + (end - start) / 2;

                if (A[calIndex] > T)
                {
                    end = calIndex - 1;
                }
                else
                {
                    start = calIndex + 1;
                }
                result.Add(A[end]);
            }

            
            return result.ToArray();
        }
    }
}