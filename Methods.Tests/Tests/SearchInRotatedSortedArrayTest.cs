using System;
using System.Collections.Generic;
using Methods.Tests.Objects;
using MethodsLibrary.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods.Tests.Tests
{
    [TestClass]
    public class SearchInRotatedSortedArrayTest
    {
        /// <summary>
        /// List to store test data set
        /// </summary>
        public List<SearchInRotatedSortedArrayTestData> TestDataList { set; get; }

        /// <summary>
        /// Initialize test data for TwoSum
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            TestDataList = new List<SearchInRotatedSortedArrayTestData>
            {
                new SearchInRotatedSortedArrayTestData
                {
                    InputArray = new[] {4, 5, 6, 7, 0, 1, 2},
                    InputInt = 4,
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
            foreach (SearchInRotatedSortedArrayTestData testData in TestDataList)
            {
                Console.WriteLine("Test iutput: " + string.Join(",", testData.InputArray));

                Assert.AreEqual(testData.OutputInt, SearchInRotatedSortedArray.Search(testData.InputArray, testData.InputInt));
            }
        }
    }
}