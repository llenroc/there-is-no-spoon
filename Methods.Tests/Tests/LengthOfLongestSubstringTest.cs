using System.Collections.Generic;
using Methods.Tests.Objects;
using MethodsLibrary.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods.Tests.Tests
{
    [TestClass]
    public class LengthOfLongestSubstringTest
    {
        /// <summary>
        /// List to store test data set
        /// </summary>
        public List<LengthOfLongestSubstringTestData> TestDataList { set; get; }

        /// <summary>
        /// Initialize test data
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            TestDataList = new List<LengthOfLongestSubstringTestData>
            {
                new LengthOfLongestSubstringTestData
                {
                    InputString = "abcabcbb",
                    OutputInt = 3
                },
                new LengthOfLongestSubstringTestData
                {
                    InputString = "bbbbb",
                    OutputInt = 1
                },
                new LengthOfLongestSubstringTestData
                {
                    InputString = "pwwkew",
                    OutputInt = 3
                },
                new LengthOfLongestSubstringTestData
                {
                    InputString = "a",
                    OutputInt = 1
                },
                new LengthOfLongestSubstringTestData
                {
                    InputString = "",
                    OutputInt = 0
                }
            };
        }

        /// <summary>
        /// Test method to verify if the method works
        /// </summary>
        [TestMethod]
        public void lengthOfLongestSubstringTest()
        {
            foreach (LengthOfLongestSubstringTestData testData in TestDataList)
            {
                Assert.AreEqual(LengthOfLongestSubstring.lengthOfLongestSubstringRevised(testData.InputString), testData.OutputInt, "Failed on the case: " + testData.InputString);
            }
        }
    }
}