namespace MethodsLibrary.Methods
{

    using MethodsLibrary.Objects;
    using System.Collections.Generic;

    public class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            ListNode slow = new ListNode(0);
            slow.next = head;
            ListNode fast = new ListNode(0);
            fast.next = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (fast == slow)
                {
                    return true;
                }
            }
            return false;
        }

        public bool HasCycleFastSlow(ListNode head)
        {
            if (head == null || head.next == null) return false;
            ListNode slow = head, fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast) return true;
            }
            return false;
        }

        public bool HasCycleHashSet(ListNode head)
        {
            var NSeen = new HashSet<ListNode>();
            while (head != null)
            {
                if (NSeen.Contains(head))
                {
                    return true;
                }
                else
                {
                    NSeen.Add(head);
                }
                head = head.next;
            }
            return false;
        }
    }
}
