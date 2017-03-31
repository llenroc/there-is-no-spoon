using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Methods.Tests.Objects;
using MethodsLibrary.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods.Tests.Tests
{
    [TestClass]
    public class LongestPalindromeTest
    {
        /// <summary>
        /// List to store test data set
        /// </summary>
        public List<LongestPalindromeTestData> TestDataList { set; get; }

        /// <summary>
        /// Initialize test data
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            TestDataList = new List<LongestPalindromeTestData>
            {
                new LongestPalindromeTestData
                {
                    InputString = "babad",
                    OutputString = "bab"
                },
                new LongestPalindromeTestData
                {
                    InputString = "cbbd",
                    OutputString = "bb"
                },
                new LongestPalindromeTestData
                {
                    InputString = "",
                    OutputString = ""
                },
                new LongestPalindromeTestData
                {
                    InputString = "",
                    OutputString = ""
                },
                new LongestPalindromeTestData
                {
                    InputString = "",
                    OutputString = ""
                }
            };
        }

        /// <summary>
        /// Test method to verify if the method works
        /// </summary>
        [TestMethod]
        public void lengthOfLongestSubstringTest()
        {
            foreach (LongestPalindromeTestData testData in TestDataList)
            {
                Assert.AreEqual(LongestPalindromeSubstring.LongestPalindrome(testData.InputString), testData.OutputString, "Failed on the case: " + testData.InputString);
            }
        }

    }
}
