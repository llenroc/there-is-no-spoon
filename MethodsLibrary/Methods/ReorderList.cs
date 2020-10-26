using MethodsLibrary.Objects;

namespace MethodsLibrary.Methods
{
    public class ReorderListClass
    {

        public void ReorderList(ListNode head)
        {
            if (head == null || head.next == null || head.next.next == null)
            {
                return;
            }

            // Find the middle node
            ListNode slow = head;
            ListNode fast = head;
            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            ListNode newHead = slow.next;
            slow.next = null; // remember to cut the list

            // Reverse the second half
            newHead = ReverseLinkedList(newHead);

            // Merge two lists
            ListNode l1_tmp;
            ListNode l2_tmp;
            while (newHead != null && head != null)
            {
                l1_tmp = head.next;
                l2_tmp = newHead.next;

                head.next = newHead;
                head = l1_tmp;

                newHead.next = head;
                newHead = l2_tmp;
            }

        }

        public ListNode ReverseLinkedList(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;
            while (curr != null)
            {
                ListNode nextTemp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextTemp;
            }
            return prev;
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
