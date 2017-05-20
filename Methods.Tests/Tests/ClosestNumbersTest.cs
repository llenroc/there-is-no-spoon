using Methods.Tests.Objects;
using MethodsLibrary.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace Methods.Tests.Tests
{
    [TestClass]
    public class ClosestNumbersTest
    {
        /// <summary>
        /// List to store test data set
        /// </summary>
        public List<ClosestNumbersTestData> TestDataList { set; get; }

        /// <summary>
        /// Initialize test data for TwoSum
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            TestDataList = new List<ClosestNumbersTestData>
            {
                new ClosestNumbersTestData()
                {
                    InputTarget = 2,
                    InputNumbers = 3,
                    InputArray = new int[] { 1, 2, 3 },
                    OutputArray = new int[] { 2, 1, 3 } // or {3, 1, 2}
                },
                new ClosestNumbersTestData()
                {
                    InputTarget = 3,
                    InputNumbers = 3,
                    InputArray = new int[] { 1, 4, 6, 8 },
                    OutputArray = new int[] { 4, 1, 6 }
                }
            };
        }

        /// <summary>
        /// Test method to verify if the method works
        /// </summary>
        [TestMethod]
        public void closestNumbersTest()
        {
            foreach (ClosestNumbersTestData testData in TestDataList)
            {
                Console.WriteLine("Test input: " + string.Join(",", testData.InputArray));
                
                CollectionAssert.AreEqual(testData.OutputArray, ClosestNumbers.closestNumbers(testData.InputTarget, testData.InputNumbers, testData.InputArray));
            }
        }

    }
}
