using System;
using System.Collections.Generic;
using Methods.Tests.Objects;
using MethodsLibrary.Methods;
using MethodsLibrary.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods.Tests.Tests
{
    [TestClass]
    public class AddTwoNumbersTest
    {
        /// <summary>
        /// List to store test data set
        /// </summary>
        public List<AddTwoNumbersTestData> TestDataList { set; get; }

        /// <summary>
        /// Initialize test data
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            TestDataList = new List<AddTwoNumbersTestData>();

            //{
            //    new AddTwoNumbersTestData()
            //    {
            //        InputListNode1 =  InitializeList1( new[] {2, 4, 3}),
            //        InputListNode2 =  InitializeList1( new[] {5, 6, 4}),
            //        InputListNode2 =  InitializeList1( new[] {7, 0, 8}),
            //    }
            //};

        }


        [TestMethod]
        public void addTwoNumbersTest()
        {
            System.Console.WriteLine(TestDataList);

            //foreach (TwoSumTestData testData in TestDataList)
            //{
            //    //CollectionAssert.AreEqual(AddTwoNumbers.addTwoNumbers(testData.InputArrayInt, testData.InputInt), testData.OutputArrayInt);
            //}

        }
    }
}
