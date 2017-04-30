using System;
using System.Collections.Generic;
using Methods.Tests.Objects;
using MethodsLibrary.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods.Tests.Tests
{
    [TestClass]
    public class ThreeSumTest
    {
        /// <summary>
        /// List to store test data set
        /// </summary>
        public List<ThreeSumTestData> TestDataList { set; get; }

        /// <summary>
        /// Initialize test data
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            TestDataList = new List<ThreeSumTestData>
            {
                new ThreeSumTestData
                {
                    InputArray = new[] {-1, 0, 1, 2, -1, -4},
                    OutputList = new List<IList<int>>
                    {
                        new List<int>
                        {
                            -1,
                            -1,
                            2
                        },
                        new List<int>
                        {
                            -1,
                            0,
                            1
                        }
                    }
                }
            };
        }

        /// <summary>
        /// Test method to verify if the method works
        /// </summary>
        [TestMethod]
        public void threeSumTest()
        {
            foreach (ThreeSumTestData testData in TestDataList)
            {
                Console.WriteLine("Testing => Input: [{0}]", string.Join(", ", testData.InputArray));


                IList<IList<int>> result = ThreeSum.threeSum(testData.InputArray);

                int i = 0;
                while ((testData.OutputList.Count == result.Count) && (i < result.Count) && (i < testData.OutputList.Count))
                {
                    Console.WriteLine("Result set " + (i+1) + " :");
                    Console.Write("Expected output: ");
                    foreach (var output in testData.OutputList[i])
                    {
                        Console.Write(output + ", ");
                    }
                    Console.WriteLine();

                    Console.Write("Actual output: ");
                    foreach (var output in result[i])
                    {
                        Console.Write(output + ", ");
                    }
                    Console.WriteLine();

                    CollectionAssert.AreEqual((List<int>) result[i], (List<int>) testData.OutputList[i],
                                              "result sets are not equal");
                    i++;
                }
            }
        }
    }
}