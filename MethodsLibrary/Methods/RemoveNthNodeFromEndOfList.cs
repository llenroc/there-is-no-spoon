
namespace MethodsLibrary.Methods
{
    using MethodsLibrary.Objects;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class RemoveNthNodeFromEndOfList
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0, head);
            ListNode first = dummy;
            ListNode second = dummy;

            while (n > 0)
            {
                first = first.next;
                n--;
            }

            while (first.next != null)
            {
                first = first.next;
                second = second.next;
            }
            second.next = second.next.next;
            //为什么不直接返回 head 呢，因为 head 有可能是被删掉的点
            return dummy.next;
        }


        [TestMethod]
        public void RemoveNthFromEndTest()
        {
            //Input: head = [1,2,3,4,5], n = 2
            //Output: [1, 2, 3, 5]

            //Input: head = [1], n = 1
            //Output: []

            //Input: head = [1,2], n = 1
            //Output: [1]

            //Input: head = [1,2], n = 2
            //Output: [2]


            ListNode h = new ListNode(0);
            ListNode head = h;
            int[] a = new int[] { 1, 2 };
            foreach (var n in a)
            {
                h.next = new ListNode(n);
                h = h.next;
            }

            head = head.next;


            head = RemoveNthFromEnd(head, 2);



            while (head != null)
            {
                Console.Write(head.val + " -> ");
                head = head.next;
            }
            Console.WriteLine();
        }
    }

    //public class ListNode
    //{
    //    public int val;
    //    public ListNode next;
    //    public ListNode(int val = 0, ListNode next = null)
    //    {
    //        this.val = val;
    //        this.next = next;
    //    }
    //}
}
