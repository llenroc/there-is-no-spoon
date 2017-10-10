
using MethodsLibrary.Objects;

namespace MethodsLibrary.Methods
{
    public class ReverseLinkedList
    {
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return null;
            }

            ListNode fake = new ListNode(0);

            while (head != null)
            {
                ListNode temp = head.next;
                head.next = fake.next;
                fake.next = head;
                head = temp;
            }

            return fake.next;
        }
    }
}
