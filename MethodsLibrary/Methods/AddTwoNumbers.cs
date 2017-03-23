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
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode addTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }
            if (l2 == null)
            {
                return l1;
            }

            ListNode resultNode = new ListNode();
            ListNode calNode = new ListNode();
            resultNode.Next = calNode;
            int jinWei = 0;

            while ((l1 != null) && (l2 != null))
            {
                calNode.Val = l1.Val + l2.Val + jinWei;
                jinWei = jinWei % 10;
                calNode.Next = new ListNode();
                calNode = calNode.Next;
                l1 = l1.Next;
                l2 = l2.Next;
            }

            if (l1 == null)
            {
                calNode.Val = jinWei + l2.Val;
                return resultNode.Next;
            }

            if (l2 == null)
            {
                calNode.Val = jinWei + l1.Val;
                return resultNode.Next;
            }
            return resultNode.Next;
        }
    }
}