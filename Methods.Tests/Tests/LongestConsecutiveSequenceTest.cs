using System;
using System.Collections.Generic;
using Methods.Tests.Objects;
using MethodsLibrary.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Methods.Tests.Tests
{
    [TestClass]
    public class LongestConsecutiveSequenceTest
    {
        /// <summary>
        /// List to store test data set
        /// </summary>
        public List<LongestConsecutiveSequenceTestData> TestDataList { set; get; }

        /// <summary>
        /// Initialize test data for TwoSum
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            TestDataList = new List<LongestConsecutiveSequenceTestData>
            {
                new LongestConsecutiveSequenceTestData
                {
                    InputArray = new[] {100, 4, 200, 1, 3, 2},
                    OutputInt = 4
                },
                new LongestConsecutiveSequenceTestData
                {
                    InputArray = new[] {7, 4, 8, 1, 3, 2, 9, 10, 11 },
                    OutputInt = 5
                },
                new LongestConsecutiveSequenceTestData
                {
                    InputArray = new[] {100},
                    OutputInt = 1
                },
                new LongestConsecutiveSequenceTestData
                {
                    InputArray = new[] { 1, 2, 0, 1},
                    OutputInt = 3
                },
                new LongestConsecutiveSequenceTestData
                {
                    InputArray = new[] { 0, 0 },
                    OutputInt = 1
                }
            };
        }

        /// <summary>
        /// Test method to verify if the method works
        /// </summary>
        [TestMethod]
        public void longestConsecutiveSequenceTest()
        {
            foreach (LongestConsecutiveSequenceTestData testData in TestDataList)
            {
                Console.WriteLine("Test iutput: " + string.Join(",", testData.InputArray));
                Console.WriteLine("Expected Output: " + testData.OutputInt);
                int result = LongestConsecutiveSequence.LongestConsecutive(testData.InputArray);
                Console.WriteLine("Actual Output: " + result);
                Assert.AreEqual(testData.OutputInt, result);
            }
        }

    }
}
