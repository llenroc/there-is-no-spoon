using System;
using System.Collections;
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

            IList list1 = new List<IList<int>>
            {
                new List<int>
                {
                    -1,
                    0,
                    1
                },
                new List<int>
                {
                    -1,
                    -1,
                    2
                }
            };

            IList list2 = new List<IList<int>>
            {
                new List<int>
                {
                    -1,
                    0,
                    1
                },
                new List<int>
                {
                    -1,
                    -1,
                    2
                }
            };

            Console.WriteLine(list1[0]);
            Console.WriteLine(list2[0]);

            Assert.AreEqual(list1[0].ToString(), list2[0].ToString(), "卧槽你马勒个大笔！");


            //int[] nums = new[] {-1, 0, 1, 2, -1, -4};
            ////Array.Sort(nums);
            ////Console.WriteLine("Testing => Input: [{0}]", string.Join(", ", nums));
            //IList<IList<int>> result = ThreeSum.threeSum(nums);
            //foreach (var smallerOnes in result)
            //{
            //    foreach (var items in smallerOnes)
            //    {
            //        Console.Write(items + " | ");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
