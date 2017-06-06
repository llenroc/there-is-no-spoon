using MethodsLibrary.Objects;

namespace Methods.Tests.Objects
{
    public class AddTwoNumbersTestData
    {
        /// <summary>
        /// Gets or sets value for singly-linked list input
        /// </summary>
        public ListNode InputListNode1 { set; get; }

        /// <summary>
        /// Gets or sets value for singly-linked list input
        /// </summary>
        public ListNode InputListNode2 { set; get; }

        /// <summary>
        /// Gets or sets value for singly-linked list input
        /// </summary>
        public ListNode InputListNode3 { set; get; }

        /// <summary>
        /// Initialized values for list from a given array (nullable)
        /// </summary>
        /// <param name="arrayInts"> Nullable input array </param>
        /// <returns> The head of the list </returns>
        public ListNode InitializeList(int?[] arrayInts)
        {
            if (arrayInts == null)
            {
                return null;
            }

            ListNode initializeListNode = new ListNode(0);
            ListNode headNode = initializeListNode;

            foreach (int number in arrayInts)
            {
                initializeListNode.next = new ListNode(number);
                initializeListNode = initializeListNode.next;
            }
            return headNode.next;
        }
    }
}