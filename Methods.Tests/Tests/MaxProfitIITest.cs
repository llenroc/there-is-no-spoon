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
    public class MaxProfitIITest
    {
        /// <summary>
        /// List to store test data set
        /// </summary>
        public List<MaxProfitTestData> TestDataList { set; get; }

        /// <summary>
        /// Initialize test data for TwoSum
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            TestDataList = new List<MaxProfitTestData>
            {
                new MaxProfitTestData()
                {
                    InputArray = new int[] { 7, 1, 5, 3, 6, 4 },
                    OutputInt = 7
                },
                new MaxProfitTestData()
                {
                    InputArray = new int[] { 7, 6, 4, 3, 1 },
                    OutputInt = 0
                }
            };
        }

        /// <summary>
        /// Test method to verify if the method works
        /// </summary>
        [TestMethod]
        public void maxProfitIITest()
        {
            foreach (MaxProfitTestData testData in TestDataList)
            {
                Console.WriteLine("Test iutput: " + string.Join(",", testData.InputArray));

                Assert.AreEqual(testData.OutputInt, MaxProfitII.maxProfitII(testData.InputArray));
            }
        }
    }
}
