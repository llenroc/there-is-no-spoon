using System;
using System.Collections.Generic;
using System.Linq;
using MethodsLibrary.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Methods.Tests.Objects;
using MethodsLibrary.Methods;

namespace Methods.Tests
{
    [TestClass]
    public class TryItHere
    {

        [TestMethod]
        public void tryItHere()
        {
            int[] nums = new[] {-1, 0, 1, 2, -1, -4};
            //Array.Sort(nums);
            //Console.WriteLine("Testing => Input: [{0}]", string.Join(", ", nums));
            IList<IList<int>> result = ThreeSum.threeSum(nums);
            foreach (var smallerOnes in result)
            {
                foreach (var items in smallerOnes)
                {
                    Console.Write(items + " | ");
                }
                Console.WriteLine();
            }
        }
    }
}
