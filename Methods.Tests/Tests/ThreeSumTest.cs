using System;
using System.Collections.Generic;
using System.Linq;
using Methods.Tests.Objects;
using MethodsLibrary.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace Methods.Tests.Tests
{
    [TestClass]
    public class ThreeSumTest
    {
        /// <summary>
        /// List to store test data set
        /// </summary>
        public List<ThreeSumTestData> TestDataList { set; get; }

        /// <summary>
        /// Initialize test data
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            TestDataList = new List<ThreeSumTestData>
            {
                new ThreeSumTestData
                {
                    InputArray = new[] {-1, 0, 1, 2, -1, -4},
                    OutputList = new List<IList<int>>
                    {
                        new List<int>
                        { -1, 0, 1 },
                        new List<int>
                        { -1, -1, 2 }
                    }
                }
            };
        }

        /// <summary>
        /// Test method to verify if the method works
        /// </summary>
        [TestMethod]
        public void threeSumTest()
        {
            //foreach (ThreeSumTestData testData in TestDataList)
            //{
            //    Console.WriteLine("Testing => Input: [{0}]", string.Join(", ", testData.InputArray));
            //    Console.WriteLine("Expected Output: " + string.Join(", ", testData.OutputList));
            //    Console.WriteLine("Testing => Input: " + testData.InputArray + "; Output: " +
            //                      ThreeSum.threeSum(testData.InputArray) + "; Expected Output: " + testData.OutputList);
            //    Assert.AreEqual(ThreeSum.threeSum(testData.InputArray),
            //                    testData.OutputList, "Failed on the case: " + testData.InputArray);
            //}

            IList<IList<int>> result = ThreeSum.threeSum(TestDataList[0].InputArray);

            foreach (var a in result)
            {
                foreach (var x in a)
                {
                    Console.Write(x + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}