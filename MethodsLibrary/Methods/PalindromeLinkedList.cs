using MethodsLibrary.Objects;

namespace MethodsLibrary.Methods
{
    public class PalindromeLinkedList
    {
        //[1,2,1]
        //[1,2,2,1]
        //[1]
        //[1,1]
        //[1,2]
        //[]
        public bool IsPalindrome(ListNode head)
        {
            ListNode fast = new ListNode();
            ListNode slow = new ListNode();
            fast.next = head;
            slow.next = head;

            while(fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            ListNode newHead = ReverseList(slow.next);
            slow.next = null;

            while (head!=null && newHead != null)
            {
                if (head.val != newHead.val)
                {
                    return false;
                }
                head = head.next;
                newHead = newHead.next;
            }
            return true;
        }

        public ListNode ReverseList(ListNode head)
        {
            ListNode pre = null;
            //ListNode cur = head;

            while (head != null)
            {
                ListNode temp = head.next;
                head.next = pre;
                pre = head;
                head = temp;
            }
            return pre;
        }
    }
}
