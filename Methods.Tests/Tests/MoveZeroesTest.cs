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
    public class MoveZeroesTest
    {
        /// <summary>
        /// List to store test data set
        /// </summary>
        public List<MoveZeroesTestData> TestDataList { set; get; }

        /// <summary>
        /// Initialize test data for TwoSum
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            TestDataList = new List<MoveZeroesTestData>
            {
                new MoveZeroesTestData()
                {
                    InputArray = new int[] { 0, 1, 0, 3, 12 },
                    OutputArray = new int[] { 1, 3, 12, 0, 0 }
                },
                new MoveZeroesTestData()
                {
                    InputArray = new int[] { 1, 0, 1, 0, 3, 12 },
                    OutputArray = new int[] { 1, 1, 3, 12, 0, 0 }
                },
                new MoveZeroesTestData()
                {
                    InputArray = new int[] { 0, 0, 0 },
                    OutputArray = new int[] { 0, 0, 0 }
                },
                new MoveZeroesTestData()
                {
                    InputArray = new int[] { 2, 3, 3 },
                    OutputArray = new int[] { 2, 3, 3 }
                },
                new MoveZeroesTestData()
                {
                    InputArray = new int[] { },
                    OutputArray = new int[] { }
                }
            };
        }

        /// <summary>
        /// Test method to verify if the method works
        /// </summary>
        [TestMethod]
        public void moveZeroesTest()
        {
            foreach (MoveZeroesTestData testData in TestDataList)
            {
                Console.WriteLine("Test input: " + string.Join(",", testData.InputArray));
                MoveZeroes.moveZeroes(testData.InputArray);
                Console.WriteLine("Test output: " + string.Join(",", testData.InputArray));

                CollectionAssert.AreEqual(testData.InputArray, testData.OutputArray);
            }
        }

    }
}
