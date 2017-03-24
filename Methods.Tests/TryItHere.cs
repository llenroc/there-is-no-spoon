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
            
            TestData testData = new TestData();
            ListNode head = testData.InputList(new int?[] {});

            //inputListNode.Next = new[] { 1, 2, 3, }.Select(i => new ListNode(i)).First();
            while (head != null)
            {
                Console.WriteLine(head.Val + ", ");
                head = head.Next;
            }
            Console.WriteLine("it's a null list");
        }
    }
}
