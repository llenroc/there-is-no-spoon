
namespace MethodsLibrary.Methods
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SquaresOfASortedArray
    {
        public int[] SortedSquares(int[] A)
        {
            int n = A.Length;
            int[] result = new int[n];
            int start = 0, end = n - 1, pos = n - 1;
            while (start<=end)
            {
                int sVal = A[start] * A[start];
                int eVal = A[end] * A[end];
                if (sVal > eVal)
                {
                    result[pos] = sVal;
                    start++;
                }
                else
                {
                    result[pos] = eVal;
                    end--;
                }
                pos--;
            }
            return result;
        }

        [TestMethod]
        public void SortedSquaresTest()
        {
            int[] a = new int[] { -4, -1, 0, 3, 10 };
            int[] b = new int[] { -7, -3, 2, 3, 11 };

            var result1 = SortedSquares(a);
            var result2 = SortedSquares(b);
            foreach (var n in result1)
            {
                System.Console.Write(n+" ");
            }
            System.Console.WriteLine();
            foreach (var n in result2)
            {
                System.Console.Write(n + " ");
            }
            System.Console.WriteLine();
        }

    }
}
