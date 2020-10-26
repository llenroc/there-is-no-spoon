using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MethodsLibrary.Objects;
using MethodsLibrary.Methods;

namespace Methods.Tests.Tests
{
    [TestClass]
    public class ReverseListTest
    {
        /// <summary>
        /// test data node
        /// </summary>
        public ListNode TestDataNode { set; get; }

        /// <summary>
        /// Initialize test data for TwoSum
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            int[] input = new int[]{1, 2, 3, 4, 5 };

            ListNode dummy = new ListNode(0);
            ListNode head = dummy;

            for (int i = 0; i < input.Length; i++)
            {
                dummy.next = new ListNode(input[i]);
                dummy = dummy.next;
            }
            TestDataNode = head.next;
        }

        [TestMethod]
        public void reverseListTest()
        {
            ListNode head = TestDataNode;
            while (head != null)
            {
                Console.Write(head.val + " -> ");
                head = head.next;
            }
            Console.WriteLine();
            head = TestDataNode;

            ListNode result = ReverseLinkedList.ReverseList(head);

            while (result != null)
            {
                Console.Write(result.val + " -> ");
                result = result.next;
            }
        }
    }
}
