using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MethodsLibrary.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Methods.Tests.Objects;
using MethodsLibrary.Methods;
using System.Text.RegularExpressions;

namespace Methods.Tests
{
    [TestClass]
    public class TryItHere
    {

        [TestMethod]
        public void tryItHere()
        {

            int InputTarget = 2;
            int[] InputArray = new int[] { 1, 4, 5,  7 };
            Console.WriteLine("Test input: " + string.Join(",", InputArray));
            Console.WriteLine("Target value: " + InputTarget);
            Console.WriteLine("Final result: " + binarySearch(InputTarget, InputArray));
        }


        public static int binarySearch(int T, int[] A)
        {
            int start = 0;
            int end = A.Length - 1;
            int iteration = 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if(A[mid] == T)
                {
                    return T;
                }

                if (A[mid] > T)
                {
                    end = mid - 1;
                }
                if(A[mid] < T)
                {
                    start = mid + 1;
                }
                Console.WriteLine("*************** interation " + iteration + "***********************");
                Console.WriteLine("mid : " + mid);
                Console.WriteLine("start : " + start);
                Console.WriteLine("end : " + end);
                iteration++;

            }

            

            return A[end];
        }
    }
}
