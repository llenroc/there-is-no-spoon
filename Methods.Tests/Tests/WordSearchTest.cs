using System;
using System.Collections.Generic;
using Methods.Tests.Objects;
using MethodsLibrary.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods.Tests.Tests
{
    [TestClass]
    public class WordSearchTest
    {
        /// <summary>
        /// List to store test data set
        /// </summary>
        public List<WordSearchTestData> TestDataList { set; get; }

        /// <summary>
        /// Initialize test data for TwoSum
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            TestDataList = new List<WordSearchTestData>
            {
                new WordSearchTestData
                {
                    Board = new[,]
                    {
                        {'A', 'B', 'C', 'E'},
                        {'S', 'F', 'C', 'S'},
                        {'A', 'D', 'E', 'E'}
                    },
                    Word = "ABCCED",
                    Result = true
                },
                new WordSearchTestData
                {
                    Board = new[,]
                    {
                        {'A', 'B', 'C', 'E'},
                        {'S', 'F', 'C', 'S'},
                        {'A', 'D', 'E', 'E'}
                    },
                    Word = "SEE",
                    Result = true
                },
                new WordSearchTestData
                {
                    Board = new[,]
                    {
                        {'A', 'B', 'C', 'E'},
                        {'S', 'F', 'C', 'S'},
                        {'A', 'D', 'E', 'E'}
                    },
                    Word = "ABCB",
                    Result = false
                }
            };
        }

        /// <summary>
        /// Test method to verify if the method works
        /// </summary>
        [TestMethod]
        public void wordSearchTest()
        {
            foreach (WordSearchTestData testData in TestDataList)
            {
                Console.WriteLine("Test input matrix: ");
                char[,] matrix = testData.Board;

                for (int i = 0; i <= matrix.GetUpperBound(0); i++)
                {
                    for (int j = 0; j <= matrix.GetUpperBound(1); j++)
                    {
                        Console.Write(matrix[i, j] + ", ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Test input word: " + testData.Word);

                bool result = WordSearch.Exist(testData.Board, testData.Word);
                Console.WriteLine("Expected output: " + testData.Result);
                Console.WriteLine("Actual output1: " + result);
                Assert.AreEqual(testData.Result, result);
            }
        }
    }
}