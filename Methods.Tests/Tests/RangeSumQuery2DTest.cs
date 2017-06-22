using System;
using System.Collections.Generic;
using Methods.Tests.Objects;
using MethodsLibrary.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods.Tests.Tests
{
    [TestClass]
    public class RangeSumQuery2DTest
    {
        /// <summary>
        /// Test matrix
        /// </summary>
        private int[,] matrix;

        /// <summary>
        /// List to store test data set
        /// </summary>
        public List<RangeSumQuery2DTestData> TestDataList { set; get; }

        /// <summary>
        /// Initialize test data for TwoSum
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            matrix = new[,]
            {
                {3, 0, 1, 4, 2},
                {5, 6, 3, 2, 1},
                {1, 2, 0, 1, 5},
                {4, 1, 0, 1, 7},
                {1, 0, 3, 0, 5}
            };

            TestDataList = new List<RangeSumQuery2DTestData>
            {
                new RangeSumQuery2DTestData
                {
                    InputArray = new[] {2, 1, 4, 3},
                    OutputInt = 8
                },
                new RangeSumQuery2DTestData
                {
                    InputArray = new[] {1, 1, 2, 2},
                    OutputInt = 11
                },
                new RangeSumQuery2DTestData
                {
                    InputArray = new[] {1, 2, 2, 4},
                    OutputInt = 12
                }
            };
        }

        /// <summary>
        /// Test method to verify if the method works
        /// </summary>
        [TestMethod]
        public void NumMatrix()
        {
            //sumRegion(2, 1, 4, 3) -> 8
            //sumRegion(1, 1, 2, 2)-> 11
            //sumRegion(1, 2, 2, 4)-> 12
            NumMatrix obj = new NumMatrix(matrix);

            foreach (RangeSumQuery2DTestData testData in TestDataList)
            {
                int sum = obj.SumRegion(testData.InputArray[0], testData.InputArray[1], testData.InputArray[2],
                                        testData.InputArray[3]);

                Console.WriteLine("Test output: " + sum);

                Assert.AreEqual(testData.OutputInt, sum);
            }
        }
    }
}