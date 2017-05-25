
using Methods.Tests.Objects;
using MethodsLibrary.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Methods.Tests.Tests
{
    [TestClass]
    public class ValidPerfectSquareTest
    {
        /// <summary>
        /// List to store test data set
        /// </summary>
        public List<ValidPerfectSquareTestData> TestDataList { set; get; }

        /// <summary>
        /// Initialize test data for TwoSum
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            TestDataList = new List<ValidPerfectSquareTestData>
            {
                new ValidPerfectSquareTestData()
                {
                    InputInt = 14,
                    OutputBool = false
                },
                new ValidPerfectSquareTestData()
                {
                    InputInt = 16,
                    OutputBool = true
                },
                new ValidPerfectSquareTestData()
                {
                    InputInt = 4,
                    OutputBool = true
                },
                new ValidPerfectSquareTestData()
                {
                    InputInt = 25,
                    OutputBool = true
                },
                new ValidPerfectSquareTestData()
                {
                    InputInt = 1,
                    OutputBool = true
                },
                new ValidPerfectSquareTestData()
                {
                    InputInt = 8,
                    OutputBool = false
                },
                new ValidPerfectSquareTestData()
                {
                    InputInt = 2147483647,
                    OutputBool = false
                }
            };
        }

        /// <summary>
        /// Test method to verify if the method works
        /// </summary>
        [TestMethod]
        public void validPerfectSquareTest()
        {
            foreach (ValidPerfectSquareTestData testData in TestDataList)
            {
                Console.WriteLine("Test input: " + testData.InputInt);

                bool result = ValidPerfectSquare.IsPerfectSquare(testData.InputInt);
                Console.WriteLine("Expected output: " + testData.OutputBool);
                Console.WriteLine("Actual output: " + result);
                Assert.AreEqual(testData.OutputBool, result);
            }
        }
    }
}
