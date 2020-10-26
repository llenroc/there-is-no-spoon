namespace MethodsLibrary.Methods
{
    using MethodsLibrary.Objects;

    public class SortListClass
    {
        public ListNode SortList(ListNode head)
        {
            ///[4,2,1,3]
            ///[-1,5,3,4,0]
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode fast = new ListNode();
            ListNode slow = new ListNode();
            fast.next = head;
            slow.next = head;

            while (fast.next != null && fast.next.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            ListNode head2 = slow.next;
            slow.next = null;
            ListNode head1 = head;
            ListNode sortedHead1 = SortList(head1);
            ListNode sortedHead2 = SortList(head2);
            return MergeLists(sortedHead1, sortedHead2);
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
    }
}
