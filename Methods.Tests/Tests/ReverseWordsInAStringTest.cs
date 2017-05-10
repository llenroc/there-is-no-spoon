using Methods.Tests.Objects;
using MethodsLibrary.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Tests.Tests
{
    [TestClass]
    public class ReverseWordsInAStringTest
    {
        /// <summary>
        /// List to store test data set
        /// </summary>
        public List<ReverseWordsInAStringTestData> TestDataList { set; get; }

        /// <summary>
        /// Initialize test data
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            TestDataList = new List<ReverseWordsInAStringTestData>
            {
                new ReverseWordsInAStringTestData
                {
                    InputString = "",
                    OutputString = ""
                },
                new ReverseWordsInAStringTestData
                {
                    InputString = "the sky is blue",
                    OutputString = "blue is sky the"
                },
                new ReverseWordsInAStringTestData
                {
                    InputString = "   a   b ",
                    OutputString = "b a"
                },
                new ReverseWordsInAStringTestData
                {
                    InputString = "hi!",
                    OutputString = "hi!"
                }
            };
        }

        /// <summary>
        /// Test method to verify if the method works
        /// </summary>
        [TestMethod]
        public void reverseWordsInAStringTest()
        {
            foreach (ReverseWordsInAStringTestData testData in TestDataList)
            {
                Console.WriteLine("Testing => Input: " + testData.InputString + "; Output: " +
                                  ReverseWordsInAString.ReverseWords(testData.InputString) +
                                  "; Expected Output: " + testData.OutputString);
                Assert.AreEqual(ReverseWordsInAString.ReverseWords(testData.InputString),
                                testData.OutputString, "Failed on the case: " + testData.InputString);
                Assert.AreEqual(ReverseWordsInAString.ReverseWordsG(testData.InputString),
                                testData.OutputString, "Failed on the case: " + testData.InputString);
                Assert.AreEqual(ReverseWordsInAString.ReverseWordsGG(testData.InputString),
                                testData.OutputString, "Failed on the case: " + testData.InputString);
            }
        }
    }
}
