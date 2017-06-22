using System;
using System.Collections.Generic;
using Methods.Tests.Objects;
using MethodsLibrary.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods.Tests.Tests
{
    [TestClass]
    public class MaximumSubarrayTest
    {
        /// <summary>
        /// List to store test data set
        /// </summary>
        public List<MaximumSubarrayTestData> TestDataList { set; get; }

        /// <summary>
        /// Initialize test data for TwoSum
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            TestDataList = new List<MaximumSubarrayTestData>
            {
                new MaximumSubarrayTestData
                {
                    InputArray = new[] {-2,1,-3,4,-1,2,1,-5,4},
                    OutputInt = 6
                },
                new MaximumSubarrayTestData
                {
                    InputArray = new[] {7, 6, 4, 3, 1},
                    OutputInt = 0
                }
            };
        }

        /// <summary>
        /// Test method to verify if the method works
        /// </summary>
        [TestMethod]
        public void MaxSubArrayTest()
        {
            foreach (MaximumSubarrayTestData testData in TestDataList)
            {
                Console.WriteLine("Test iutput: " + string.Join(",", testData.InputArray));

                Assert.AreEqual(testData.OutputInt, MaximumSubarray.MaxSubArray(testData.InputArray));
            }
        }
    }
}