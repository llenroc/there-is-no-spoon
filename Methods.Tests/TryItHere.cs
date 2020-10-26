
namespace Methods.Tests
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using MethodsLibrary.Objects;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Methods.Tests.Objects;
    using MethodsLibrary.Methods;
    using System.Text.RegularExpressions;

    [TestClass]
    public class TryItHere
    {

        [TestMethod]
        public void TryIt()
        {
            //Dictionary<char, int> dic = new Dictionary<char, int>();

            //dic.Add('s', 1);
            //Console.WriteLine(dic['s']);
            //Console.WriteLine(++dic['s']);
            int[] l1 = new int[] {1,3,5,7,9 };
            int[] l2 = new int[] { 2, 4, 6, 8, 10,66,99 };
            ListNode head1 = Helper.CreateListFromArray(l1);
            ListNode head2 = Helper.CreateListFromArray(l2);
            var head = MergeLists(head1, head2);

            Helper.PrintList(head);

        }

        public ListNode MergeLists(ListNode head1, ListNode head2)
        {
            ListNode dummy = new ListNode();
            ListNode newHead = dummy;

            while (head1 != null && head2 != null)
            {
                if (head1.val < head2.val)
                {
                    dummy.next = head1;
                    dummy = dummy.next;
                    head1 = head1.next;
                }
                else
                {
                    dummy.next = head2;
                    dummy = dummy.next;
                    head2 = head2.next;
                }
            }
            while (head1 != null)
            {
                dummy.next = head1;
                dummy = dummy.next;
                head1 = head1.next;

            }
            while (head2 != null)
            {
                dummy.next = head2;
                dummy = dummy.next;
                head2 = head2.next;
            }
            return newHead.next;
        }


        public static int BinarySearch(int T, int[] A)
        {
            int start = 0;
            int end = A.Length - 1;
            int iteration = 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (A[mid] == T)
                {
                    return T;
                }

                if (A[mid] > T)
                {
                    end = mid - 1;
                }
                if (A[mid] < T)
                {
                    start = mid + 1;
                }
                Console.WriteLine("*************** interation " + iteration + "***********************");
                Console.WriteLine("mid : " + mid);
                Console.WriteLine("start : " + start);
                Console.WriteLine("end : " + end);
                iteration++;

            }



            return A[end];
        }


    }
}
