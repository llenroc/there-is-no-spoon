using System.Collections.Generic;
using Methods.Tests.Objects;
using MethodsLibrary.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods.Tests.Tests
{
    [TestClass]
    class ValidPalindromeTest
    {
        /// <summary>
        /// List to store test data set
        /// </summary>
        public List<ValidPalindromeTestData> TestDataList { set; get; }

        /// <summary>
        /// Initialize test data
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            TestDataList = new List<ValidPalindromeTestData>
            {
                new ValidPalindromeTestData
                {
                    InputString = "A man, a plan, a canal: Panama",
                    OutputBool = true
                },
                new ValidPalindromeTestData
                {
                    InputString = "race a car",
                    OutputBool = false
                }
            };
        }

        /// <summary>
        /// Test method to verify if the method works
        /// </summary>
        [TestMethod]
        public void validPalindromeTest()
        {
            foreach (ValidPalindromeTestData testData in TestDataList)
            {
                System.Console.WriteLine("Input String:" + testData.InputString);
                Assert.AreEqual(ValidPalindrome.IsPalindrome(testData.InputString),
                                testData.OutputBool, "Failed on the case: " + testData.InputString);
            }
        }
    }
}
