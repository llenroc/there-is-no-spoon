


namespace MethodsLibrary.Methods
{
    using MethodsLibrary.Objects;

    public class LinkedListCycleII
    {
        public ListNode DetectCycle(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    fast = head;
                    while (fast != slow)
                    {
                        slow = slow.next;
                        fast = fast.next;
                    }
                    return fast;
                }
            }

            return null;
        }

        public ListNode DetectCycleOld(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return null;
            }
            //判断是不是有环
            ListNode fast = head.next;
            ListNode slow = head;
            while (fast != slow)
            {
                if (fast == null || fast.next == null)
                    return null;
                fast = fast.next.next;
                slow = slow.next;
            }
            //找到环后找连接点
            while (head != slow.next)
            {
                head = head.next;
                slow = slow.next;
            }
            return head;
        }
    }
}
