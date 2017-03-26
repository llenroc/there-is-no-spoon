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
            AddTwoNumbersTestData testData1 = new AddTwoNumbersTestData();
            testData1.InputListNode1 = testData1.InitializeList(new int?[] {2, 4, 3});
            testData1.InputListNode2 = testData1.InitializeList(new int?[] {5, 6, 4});
            testData1.InputListNode3 = testData1.InitializeList(new int?[] {7, 0, 8});

            AddTwoNumbersTestData testData2 = new AddTwoNumbersTestData();
            testData2.InputListNode1 = testData2.InitializeList(new int?[] {2, 4, 3});
            testData2.InputListNode2 = testData2.InitializeList(new int?[] {});
            testData2.InputListNode3 = testData2.InitializeList(new int?[] {2, 4, 3});

            AddTwoNumbersTestData testData3 = new AddTwoNumbersTestData();
            testData3.InputListNode1 = testData3.InitializeList(new int?[] {2, 4, 3});
            testData3.InputListNode2 = testData3.InitializeList(new int?[] {4, 6});
            testData3.InputListNode3 = testData3.InitializeList(new int?[] {6, 0, 4});

            TestDataList = new List<AddTwoNumbersTestData>
            {
                testData1,
                testData2,
                testData3
            };
        }

        [TestMethod]
        public void addTwoNumbersTest()
        {
            foreach (AddTwoNumbersTestData testData in TestDataList)
            {
                ListNode resultNode = AddTwoNumbers.addTwoNumbers(testData.InputListNode1, testData.InputListNode2);
                ListNode expectedResult = testData.InputListNode3;
                while ((resultNode != null) && (expectedResult != null))
                {
                    Console.WriteLine("result is " + resultNode.val + ", expected result is " + expectedResult.val);
                    Assert.AreEqual(resultNode.val, expectedResult.val, "Test failed");
                    resultNode = resultNode.next;
                    expectedResult = expectedResult.next;
                }
                if (resultNode != null)
                {
                    Assert.Fail("Failed on extra node " + resultNode.val);
                }
                if (expectedResult != null)
                {
                    Assert.Fail("Failed on extra node " + expectedResult.val);

                }
                Console.WriteLine("************************************");
            }
        }
    }
}