using System;
using System.Collections.Generic;
using Methods.Tests.Objects;
using MethodsLibrary.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods.Tests.Tests
{
    [TestClass]
    public class NQueensTest
    {
        /// <summary>
        /// List to store test data set
        /// </summary>
        public List<NQueensTestData> TestDataList { set; get; }

        /// <summary>
        /// Initialize test data
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            TestDataList = new List<NQueensTestData>
            {
                new NQueensTestData
                {
                    Input = 4,
                    OutputList = new List<List<string>>
                    {
                        new List<string>
                        {
                            ".Q..",
                            "...Q",
                            "Q...",
                            "..Q."
                        },
                        new List<string>
                        {
                            "..Q.",
                            "Q...",
                            "...Q",
                            ".Q.."
                        }
                    }
                }
            };
        }

        /// <summary>
        /// Test method to verify if the method works
        /// </summary>
        [TestMethod]
        public void nQueensTest()
        {
            foreach (var testdata in TestDataList)
            {
                foreach (var output in testdata.OutputList)
                {
                    Console.WriteLine(NQueens.isLegit(output));
                }
            }
        }
    }
}