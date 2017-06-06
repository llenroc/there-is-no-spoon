using System;
using System.Collections.Generic;
using Methods.Tests.Objects;
using MethodsLibrary.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods.Tests.Tests
{
    [TestClass]
    public class MaxProfitTest
    {
        /// <summary>
        /// List to store test data set
        /// </summary>
        public List<MaxProfitTestData> TestDataList { set; get; }

        /// <summary>
        /// Initialize test data for TwoSum
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            TestDataList = new List<MaxProfitTestData>
            {
                new MaxProfitTestData
                {
                    InputArray = new[] {7, 1, 5, 3, 6, 4},
                    OutputInt = 5
                },
                new MaxProfitTestData
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
        public void maxProfitTest()
        {
            foreach (MaxProfitTestData testData in TestDataList)
            {
                Console.WriteLine("Test iutput: " + string.Join(",", testData.InputArray));

                Assert.AreEqual(testData.OutputInt, MaxProfit.maxProfit(testData.InputArray));
                Assert.AreEqual(testData.OutputInt, MaxProfit.maxProfitG(testData.InputArray));
                Assert.AreEqual(testData.OutputInt, MaxProfit.maxProfitGG(testData.InputArray));
            }
        }
    }
}