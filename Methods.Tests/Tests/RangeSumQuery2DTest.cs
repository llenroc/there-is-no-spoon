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
        private int[][] matrix;

        /// <summary>
        /// Initialize test data for TwoSum
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            matrix = new [][]{
                { 3, 0, 1, 4, 2},
                { 5, 6, 3, 2, 1},
                { 1, 2, 0, 1, 5},
                { 4, 1, 0, 1, 7},
                { 1, 0, 3, 0, 5}
            }
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
            //Assert.AreEqual(testData.OutputInt, SearchInRotatedSortedArray.Search(testData.InputArray, testData.InputInt));
        }
    }
}
