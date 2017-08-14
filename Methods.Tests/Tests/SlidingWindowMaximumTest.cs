using System;
using System.Collections.Generic;
using Methods.Tests.Objects;
using MethodsLibrary.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods.Tests.Tests
{
    [TestClass]
    public class SlidingWindowMaximumTest
    {
        /// <summary>
        /// List to store test data set
        /// </summary>
        public List<SlidingWindowMaximumTestData> TestDataList { set; get; }

        /// <summary>
        /// Initialize test data for TwoSum
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            TestDataList = new List<SlidingWindowMaximumTestData>
            {
                new SlidingWindowMaximumTestData
                {
                    InputNumber = 3,
                    InputArray = new[] { 1, 3, -1, -3, 5, 3, 6, 7},
                    OutputArray = new[] { 3, 3, 5, 5, 6, 7 }
                },
                new SlidingWindowMaximumTestData
                {
                    InputNumber = 0,
                    InputArray = new int[] { },
                    OutputArray = new int[] { }
                }
            };
        }

        /// <summary>
        /// Test method to verify if the method works
        /// </summary>
        [TestMethod]
        public void slidingWindowMaximumTest()
        {
            foreach (SlidingWindowMaximumTestData testData in TestDataList)
            {
                Console.WriteLine("Test input k = " + testData.InputNumber);
                Console.WriteLine("Test input array: " + string.Join(",", testData.InputArray));
                Console.WriteLine("Expected output: " + string.Join(",", testData.OutputArray));
                int[] result = SlidingWindowMaximum.MaxSlidingWindow(testData.InputArray, testData.InputNumber);
                Console.WriteLine("Actual output: " + string.Join(",", result));
                CollectionAssert.AreEqual(testData.OutputArray, result);
            }
        }

    }
}
