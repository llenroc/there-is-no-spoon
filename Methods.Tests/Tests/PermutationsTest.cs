using System;
using System.Collections.Generic;
using Methods.Tests.Objects;
using MethodsLibrary.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods.Tests.Tests
{
    [TestClass]
    public class PermutationsTest
    {
        /// <summary>
        /// List to store test data set
        /// </summary>
        public List<PermutationsTestData> TestDataList { set; get; }

        /// <summary>
        /// Initialize test data
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            TestDataList = new List<PermutationsTestData>
            {
                new PermutationsTestData
                {
                    Input = new int[]{1, 2, 3 },
                    OutputList = new List<List<int>>
                    {
                        new List<int>
                        {
                            1, 2, 3
                        },
                        new List<int>
                        {
                            1, 3, 2
                        },
                        new List<int>
                        {
                            2, 1, 3
                        },
                        new List<int>
                        {
                            2, 3, 1
                        },
                        new List<int>
                        {
                            3, 1, 2
                        },
                        new List<int>
                        {
                            3, 2, 1
                        }
                    }
                }
            };
        }

        /// <summary>
        /// Test method to verify if the method works
        /// </summary>
        [TestMethod]
        public void permutationsTest()
        {
            foreach (var testdata in TestDataList)
            {
                IList<IList<int>> queens = Permutations.Permute(testdata.Input);
                foreach (var output in queens)
                {
                    foreach (var chessboard in output)
                    {
                        Console.WriteLine(chessboard);
                    }
                    Console.WriteLine("******************");
                }
            }
        }
    }
}