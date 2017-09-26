
namespace Methods.Tests.Objects
{
    /// <summary>
    /// Define different inputs for testing
    /// contains different data structures 
    /// </summary>
    public class WordSearchTestData
    {
        /// <summary>
        /// Gets or sets a 2D char type array input for testing
        /// </summary>
        public char[,] Board { get; set; }

        /// <summary>
        /// Gets or sets a int type input for testing
        /// </summary>
        public string Word { get; set; }

        /// <summary>
        /// Gets or sets a boolean type output for testing
        /// </summary>
        public bool Result { set; get; }
    }
}
