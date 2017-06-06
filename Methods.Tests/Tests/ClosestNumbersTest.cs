using System;
using System.Collections.Generic;
using Methods.Tests.Objects;
using MethodsLibrary.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
                new ClosestNumbersTestData
                {
                    InputTarget = 2,
                    InputNumbers = 3,
                    InputArray = new[] {1, 2, 3},
                    OutputArray = new[] {2, 1, 3} // or {3, 1, 2}
                },
                new ClosestNumbersTestData
                {
                    InputTarget = 3,
                    InputNumbers = 3,
                    InputArray = new[] {1, 4, 6, 8},
                    OutputArray = new[] {4, 1, 6}
                },
                new ClosestNumbersTestData
                {
                    InputTarget = 1,
                    InputNumbers = 3,
                    InputArray = new[] {1, 4, 6, 8},
                    OutputArray = new[] {1, 4, 6}
                },
                new ClosestNumbersTestData
                {
                    InputTarget = 8,
                    InputNumbers = 3,
                    InputArray = new[] {1, 4, 6, 8},
                    OutputArray = new[] {8, 6, 4}
                },
                new ClosestNumbersTestData
                {
                    InputTarget = 3,
                    InputNumbers = 3,
                    InputArray = new[] {1, 4, 6, 8},
                    OutputArray = new[] {4, 1, 6}
                },
                new ClosestNumbersTestData
                {
                    InputTarget = 5,
                    InputNumbers = 3,
                    InputArray = new[] {1, 4, 6, 8},
                    OutputArray = new[] {4, 6, 8}
                },
                new ClosestNumbersTestData
                {
                    InputTarget = 7,
                    InputNumbers = 2,
                    InputArray = new[] {1, 4, 6, 8},
                    OutputArray = new[] {6, 8}
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

                int[] result = ClosestNumbers.closestNumbers(testData.InputTarget, testData.InputNumbers,
                                                             testData.InputArray);
                Console.WriteLine("Test output: " + string.Join(",", result));

                CollectionAssert.AreEqual(testData.OutputArray, result);
            }
        }
    }
}