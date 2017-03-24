using System;
using System.Collections.Generic;
using System.Linq;
using MethodsLibrary.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Methods.Tests.Objects;

namespace Methods.Tests
{
    [TestClass]
    public class TryItHere
    {

        [TestMethod]
        public void tryItHere()
        {
            
            ListNode inputListNode = new ListNode();
            TestData testData = new TestData
            {
                InputListNode = inputListNode
            };
            //ListNode head = inputListNode;
            int[] data = new[] {1, 2, 3};
            foreach (var number in data)
            {
                inputListNode.Next = new ListNode(number);
                inputListNode = inputListNode.Next;
            }

            //inputListNode.Next = new[] { 1, 2, 3, }.Select(i => new ListNode(i)).First();
            while (testData.InputListNode.Next != null)
            {
                Console.WriteLine(testData.InputListNode.Next.Val + ", ");
                testData.InputListNode = testData.InputListNode.Next;
            }
        }
    }
}
