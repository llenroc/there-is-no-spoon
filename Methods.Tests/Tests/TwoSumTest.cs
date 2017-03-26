using System.Collections.Generic;
using Methods.Tests.Objects;
using MethodsLibrary.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods.Tests.Tests
{
    [TestClass]
    public class TwoSumTest
    {
        /// <summary>
        /// List to store test data set
        /// </summary>
        public List<TwoSumTestData> TestDataList { set; get; }

        /// <summary>
        /// Initialize test data for TwoSum
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            TestDataList = new List<TwoSumTestData>
            {
                new TwoSumTestData()
                {
                    InputArrayInt = new int[] {0, 0},
                    InputInt = 0,
                    OutputArrayInt = new int[] {0, 1}
                },
                new TwoSumTestData()
                {
                    InputArrayInt = new int[] {2, 7, 11, 15},
                    InputInt = 9,
                    OutputArrayInt = new int[] {0, 1}
                },
                new TwoSumTestData()
                {
                    InputArrayInt = new int[] {3, 2, 4},
                    InputInt = 6,
                    OutputArrayInt = new int[] {1, 2}
                },
                new TwoSumTestData()
                {
                    InputArrayInt = new int[] { 230, 863, 916, 585, 981, 404, 316, 785, 88, 12, 70, 435, 384, 778, 887, 755, 740, 337, 86, 92, 325, 422, 815, 650, 920, 125, 277, 336, 221, 847, 168, 23, 677, 61, 400, 136, 874, 363, 394, 199, 863, 997, 794, 587, 124, 321, 212, 957, 764, 173, 314, 422, 927, 783, 930, 282, 306, 506, 44, 926, 691, 568, 68, 730, 933, 737, 531, 180, 414, 751, 28, 546, 60, 371, 493, 370, 527, 387, 43, 541, 13, 457, 328, 227, 652, 365, 430, 803, 59, 858, 538, 427, 583, 368, 375, 173, 809, 896, 370, 789 },
                    InputInt = 542,
                    OutputArrayInt = new int[] {28, 45}
                }
            };
        }

        /// <summary>
        /// Test method to verify if the method works
        /// </summary>
        [TestMethod]
        public void twoSumTest()
        {
            foreach(TwoSumTestData testData in TestDataList)
            {
                CollectionAssert.AreEqual(TwoSum.twoSum(testData.InputArrayInt, testData.InputInt), testData.OutputArrayInt);
            }
        }
    }
}
