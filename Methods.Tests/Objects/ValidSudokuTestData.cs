
namespace Methods.Tests.Objects
{
    /// <summary>
    /// Define different inputs for testing
    /// contains different data structures 
    /// </summary>
    public class ValidSudokuTestData
    {
        /// <summary>
        /// Gets or sets a 2D int type array input for testing
        /// </summary>
        public char[,] InputArray { get; set; }

        /// <summary>
        /// Gets or sets a boolean type output for testing
        /// </summary>
        public bool OutputBool { set; get; }
    }
}
