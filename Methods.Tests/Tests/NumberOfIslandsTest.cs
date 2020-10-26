

namespace Methods.Tests.Tests
{
    using MethodsLibrary.Methods;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class NumberOfIslandsTest
    {

        /// <summary>
        ///     Test method to verify if the method works
        /// </summary>
        [TestMethod]
        public void NumIslandsTest()
        {
            char[][] grid1 = new char[][] {new char[] {'1', '1', '1', '1', '0'},
                                           new char[] {'1', '1', '0', '1', '0'},
                                           new char[] {'1', '1', '0', '0', '0'},
                                           new char[] {'0', '0', '0', '0', '0'}, };
            int output = 1;

            char[][] grid2 = new char[][] {new char[] {'1', '1', '0', '0', '0'},
                                           new char[] {'1', '1', '0', '0', '0'},
                                           new char[] {'0', '0', '1', '0', '0'},
                                           new char[] {'0', '0', '0', '1', '1'}, };
            int output2 = 3;
            Assert.AreEqual(NumberOfIslands.NumIslands(grid2), output2);
        }
    }
}
