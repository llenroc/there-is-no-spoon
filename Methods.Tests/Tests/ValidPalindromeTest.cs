namespace Methods.Tests.Tests
{
    using System;
    using System.Collections.Generic;
    using MethodsLibrary.Methods;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Objects;

    [TestClass]
    public class ValidPalindromeTest
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
                },
                new ValidPalindromeTestData
                {
                    InputString = ",.",
                    OutputBool = true
                },
                new ValidPalindromeTestData
                {
                    InputString = "      ",
                    OutputBool = true
                },
                new ValidPalindromeTestData
                {
                    InputString = ",  ,",
                    OutputBool = true
                },
                new ValidPalindromeTestData
                {
                    InputString = "  ,  ",
                    OutputBool = true
                },
                new ValidPalindromeTestData
                {
                    InputString = "  3  ",
                    OutputBool = true
                },
                new ValidPalindromeTestData
                {
                    InputString = "23.4,32",
                    OutputBool = true
                },
                new ValidPalindromeTestData
                {
                    InputString = "123",
                    OutputBool = false
                },
                new ValidPalindromeTestData
                {
                    InputString = "abc",
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
                Console.WriteLine("Input String:" + testData.InputString);
                var result = ValidPalindrome.IsPalindrome(testData.InputString);
                Console.WriteLine("Result: " + result);
                Assert.AreEqual(testData.OutputBool, result,
                                "Failed on the case: " + testData.InputString);
            }
        }
    }
}