using MethodsLibrary.Objects;

namespace MethodsLibrary.Methods
{
    public class AddTwoNumbers
    {
        /// <summary>
        /// You are given two non-empty linked lists representing two non-negative integers. 
        /// The digits are stored in reverse order and each of their nodes contain a single digit. 
        /// Add the two numbers and return it as a linked list.
        /// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
        /// Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        /// Output: 7 -> 0 -> 8
        /// </summary>
        /// <param name="l1"> Head of a non-empty linked list representing a non-negative integer </param>
        /// <param name="l2"> Head of a non-empty linked list representing a non-negative integer </param>
        /// <returns> Head of result list </returns>
        public static ListNode addTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode calNode = new ListNode(0);
            ListNode resultNode= calNode;
            int jinWei = 0;

            while ((l1 != null) || (l2 != null))
            {
                jinWei /= 10;
                if (l1 != null)
                {
                    jinWei += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    jinWei += l2.val;
                    l2 = l2.next;
                }
                calNode.next = new ListNode(jinWei % 10);
                calNode = calNode.next;
            }
            if ((jinWei / 10) == 1)
            {
                calNode.next = new ListNode(1);
            }
            return resultNode.next;
        }
    }
}