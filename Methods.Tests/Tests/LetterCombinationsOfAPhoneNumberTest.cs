using System;
using System.Collections.Generic;
using Methods.Tests.Objects;
using MethodsLibrary.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods.Tests.Tests
{
    [TestClass]
    public class LetterCombinationsOfAPhoneNumberTest
    {
        /// <summary>
        /// List to store test data set
        /// </summary>
        public List<LetterCombinationsTestData> TestDataList { set; get; }

        /// <summary>
        /// Initialize test data for TwoSum
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            TestDataList = new List<LetterCombinationsTestData>
            {
                new LetterCombinationsTestData
                {
                    Input = "23",
                    OutputList = new List<string>
                    {
                        "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"
                    }
                },
                new LetterCombinationsTestData
                {
                    Input = "7",
                    OutputList = new List<string>
                    {
                        "p","q","r","s"
                    }
                }
            };
        }

        /// <summary>
        /// Test method to verify if the method works
        /// </summary>
        [TestMethod]
        public void letterCombinationsTest()
        {
            foreach (LetterCombinationsTestData testData in TestDataList)
            {
                Console.WriteLine("Test iutput: " + testData.Input);

                IList<string> result = LetterCombinationOfPhoneNumber.LetterCombinations(testData.Input);

                Assert.IsTrue(result.Count == testData.OutputList.Count, "Not enough result!");

                for (int i = 0; i < result.Count; i++)
                {
                    Console.WriteLine(result[i]);
                    Assert.AreEqual(testData.OutputList[i], result[i]);
                }
                
            }
        }
    }
}