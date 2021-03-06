﻿using System;
using System.Collections.Generic;
using Methods.Tests.Objects;
using MethodsLibrary.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods.Tests.Tests
{
    [TestClass]
    public class TrappingRainWaterTest
    {
        /// <summary>
        /// List to store test data set
        /// </summary>
        public List<TrappingRainWaterTestData> TestDataList { set; get; }

        /// <summary>
        /// Initialize test data for TwoSum
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            TestDataList = new List<TrappingRainWaterTestData>
            {
                new TrappingRainWaterTestData
                {
                    InputArray = new[] {0,1,0,2,1,0,1,3,2,1,2,1},
                    OutputInt = 6
                },
                new TrappingRainWaterTestData
                {
                    InputArray = new[] {7, 6, 4, 3, 1},
                    OutputInt = 0
                }
            };
        }

        /// <summary>
        /// Test method to verify if the method works
        /// </summary>
        [TestMethod]
        public void trappingRainWaterTest()
        {
            foreach (TrappingRainWaterTestData testData in TestDataList)
            {
                Console.WriteLine("Test iutput: " + string.Join(",", testData.InputArray));
                Console.WriteLine("Expected output: " + testData.OutputInt);
                int maxWater = TrappingRainWater.Trap(testData.InputArray);
                Console.WriteLine("Actual output: " + maxWater);
                Assert.AreEqual(testData.OutputInt, maxWater);
            }
        }
    }
}