using MethodsLibrary.Objects;

namespace Methods.Tests.Objects
{
    /// <summary>
    /// Define different inputs for testing
    /// contains different data structures 
    /// </summary>
    public class TestData
    {
        /// <summary>
        /// Gets or sets a string type input for testing
        /// </summary>
        public string InputString { get; set; }

        /// <summary>
        /// Gets or sets a string type output for testing
        /// </summary>
        public string OutputString { get; set; }

        /// <summary>
        /// Gets or sets an array with int type as input for testing
        /// </summary>
        public int[] InputArrayInt { get; set; }

        /// <summary>
        /// Gets or sets an array with int type as output for testing
        /// </summary>
        public int[] OutputArrayInt { get; set; }

        /// <summary>
        /// Gets or sets a int type input for testing
        /// </summary>
        public int InputInt { set; get; }

        /// <summary>
        /// Gets or sets a int type output for testing
        /// </summary>
        public int OutputInt { set; get; }

        /// <summary>
        /// Gets or sets value for singly-linked list input
        /// </summary>
        public ListNode InputListNode { set; get; }

        /// <summary>
        /// Gets or sets value for singly-linked list output
        /// </summary>
        public ListNode OutputListNode { set; get; }

    }
}
