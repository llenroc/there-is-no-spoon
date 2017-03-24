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
        public List<TestData> TestDataList { set; get; }

        /// <summary>
        /// Initialize test data
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            TestDataList = new List<TestData>();
            //ListNode head1 = TestDataList.Add(new new List<TestData> {});

        }

        [TestMethod]
        public void addTwoNumbersTest()
        {

            foreach (TestData testData in TestDataList)
            {
                //CollectionAssert.AreEqual(AddTwoNumbers.addTwoNumbers(testData.InputArrayInt, testData.InputInt), testData.OutputArrayInt);
            }

        }
    }
}
