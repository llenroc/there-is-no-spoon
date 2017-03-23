using System;
using System.Collections.Generic;
using System.Linq;
using MethodsLibrary.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods.Tests
{
    [TestClass]
    public class TryItHere
    {

        [TestMethod]
        public void tryItHere()
        {

            ListNode inputListNode = new ListNode();
            ListNode head = inputListNode;
            int[] data = new[] {1, 2, 3};
            foreach (var number in data)
            {
                inputListNode.Next = new ListNode(number);
                inputListNode = inputListNode.Next;
            }

            //inputListNode.Next = new[] { 1, 2, 3, }.Select(i => new ListNode(i)).First();
            while (head.Next != null)
            {
                Console.WriteLine(head.Next.Val + ", ");
                head = head.Next;
            }
        }
    }
}
