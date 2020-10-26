namespace MethodsLibrary.Methods
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class LongestMountainInArray
    {
        public int LongestMountain(int[] A)
        {
            int maxLength = 0;
            int n = 1;

            while (n < A.Length)
            {
                int increasing = 0, decreasing = 0;

                while (n < A.Length && A[n - 1] < A[n])
                {
                    n++;
                    increasing++;
                }

                while (n < A.Length && A[n - 1] > A[n])
                {
                    n++;
                    decreasing++;
                }

                if (increasing > 0 && decreasing > 0)
                {
                    maxLength = Math.Max(maxLength, increasing + decreasing + 1);
                }

                while (n < A.Length && A[n - 1] == A[n]) n++;
            }
            return maxLength;
        }

        [TestMethod]
        public void LongestMountainTest()
        {
            int[] A = new int[] { 2, 1, 4, 7, 3, 2, 5 }; //5

            Console.WriteLine(LongestMountain(A));
        }
    }
}
