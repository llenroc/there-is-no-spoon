using System;
using System.Collections.Generic;
using Methods.Tests.Objects;
using MethodsLibrary.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods.Tests.Tests
{
    [TestClass]
    public class SearchA2DMatrixTest
    {
        /// <summary>
        /// List to store test data set
        /// </summary>
        public List<SearchA2DMatrixTestData> TestDataList { set; get; }

        /// <summary>
        /// Initialize test data for TwoSum
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            TestDataList = new List<SearchA2DMatrixTestData>
            {
                new SearchA2DMatrixTestData
                {
                    InputArray = new[,]
                    {
                        {1, 3, 5, 7},
                        {10, 11, 16, 20},
                        {23, 30, 34, 50}
                    },
                    InputInt = 3,
                    OutputBool = true
                },
                new SearchA2DMatrixTestData
                {
                    InputArray = new[,]
                    {
                        {1, 3, 5, 7},
                        {10, 11, 16, 20},
                        {23, 30, 34, 50}
                    },
                    InputInt = 10,
                    OutputBool = true
                },
                new SearchA2DMatrixTestData
                {
                    InputArray = new[,]
                    {
                        {1, 3, 5, 7},
                        {10, 11, 16, 20},
                        {23, 30, 34, 50}
                    },
                    InputInt = 50,
                    OutputBool = true
                },
                new SearchA2DMatrixTestData
                {
                    InputArray = new[,]
                    {
                        {1, 3, 5, 7},
                        {10, 11, 16, 20},
                        {23, 30, 34, 50}
                    },
                    InputInt = 20,
                    OutputBool = true
                },
                new SearchA2DMatrixTestData
                {
                    InputArray = new[,]
                    {
                        {2}
                    },
                    InputInt = 3,
                    OutputBool = false
                },
                new SearchA2DMatrixTestData
                {
                    InputArray = new[,]
                    {
                        {1, 1}
                    },
                    InputInt = 2,
                    OutputBool = false
                },
                new SearchA2DMatrixTestData
                {
                    InputArray = new[,]
                    {
                        {1, 3}
                    },
                    InputInt = 1,
                    OutputBool = true
                },
                new SearchA2DMatrixTestData
                {
                    InputArray = new int[,]{},
                    InputInt = 0,
                    OutputBool = false
                }
            };
        }

        /// <summary>
        /// Test method to verify if the method works
        /// </summary>
        [TestMethod]
        public void searchA2DMatrixTest()
        {
            foreach (SearchA2DMatrixTestData testData in TestDataList)
            {
                Console.WriteLine("Test input matrix: ");
                int[,] matrix = testData.InputArray;
                for (int i = 0; i <= matrix.GetUpperBound(0); i++)
                {
                    for (int j = 0; j <= matrix.GetUpperBound(1); j++)
                    {
                        Console.Write(matrix[i, j] + ", ");
                    }
                    Console.WriteLine();
                }
                bool result = SearchA2DMatrix.SearchMatrix(testData.InputArray, testData.InputInt);
                bool newResult = SearchA2DMatrix.SearchMatrixRevised(testData.InputArray, testData.InputInt);
                bool newResult2 = SearchA2DMatrix.SearchMatrixRevised(testData.InputArray, testData.InputInt);
                Console.WriteLine("Expected output: " + testData.OutputBool);
                Console.WriteLine("Actual output1: " + result);
                Console.WriteLine("Actual output2: " + newResult);
                Console.WriteLine("Actual output2: " + newResult2);
                Assert.AreEqual(testData.OutputBool, result);
                Assert.AreEqual(testData.OutputBool, newResult);
                Assert.AreEqual(testData.OutputBool, newResult2);
            }
        }
    }
}