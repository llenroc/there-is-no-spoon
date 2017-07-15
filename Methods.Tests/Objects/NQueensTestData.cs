
using System.Collections.Generic;

namespace Methods.Tests.Objects
{
    public class NQueensTestData
    {
        /// <summary>
        /// Gets or sets a int type input for testing
        /// </summary>
        public int Input { get; set; }

        /// <summary>
        /// Gets or sets a string list type output for testing
        /// </summary>
        public IList<List<string>> OutputList { set; get; }
    }
}
