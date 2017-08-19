using System;
using System.Collections.Generic;
using Methods.Tests.Objects;
using MethodsLibrary.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods.Tests.Tests
{
    [TestClass]
    public class CoinChange2Test
    {
        /// <summary>
        /// List to store test data set
        /// </summary>
        public List<CoinChange2TestData> TestDataList { set; get; }

        /// <summary>
        /// Initialize test data for TwoSum
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            TestDataList = new List<CoinChange2TestData>
            {
                //new CoinChange2TestData
                //{
                //    InputArray = new[] {1, 2, 5},
                //    InputInt = 5,
                //    OutputInt = 4
                //},
                //new CoinChange2TestData
                //{
                //    InputArray = new[] {2},
                //    InputInt = 3,
                //    OutputInt = 0
                //},
                //new CoinChange2TestData
                //{
                //    InputArray = new[] {10},
                //    InputInt = 10,
                //    OutputInt = 1
                //},
                new CoinChange2TestData
                {
                    InputArray = new[] {2, 1},
                    InputInt = 4,
                    OutputInt = 3
                }
            };
        }

        /// <summary>
        /// Test method to verify if the method works
        /// </summary>
        [TestMethod]
        public void coinChange2Test()
        {
            foreach (CoinChange2TestData testData in TestDataList)
            {
                Console.WriteLine("Test iutput: " + string.Join(",", testData.InputArray));

                Assert.AreEqual(testData.OutputInt, CoinChange2.Change(testData.InputInt, testData.InputArray));
            }
        }

    }
}
