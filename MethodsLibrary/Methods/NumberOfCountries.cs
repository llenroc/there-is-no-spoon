namespace MethodsLibrary.Methods
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class NumberOfCountries
    {
        // This could be done in-place. 
        // Just turn '1's into '0's to mark it as visited.
        private static bool[,] marked;

        public int NumOfCountries (int[][] grid)
        {
            if (grid == null || grid.Length == 0)
            {
                return 0;
            }

            marked = new bool[grid.Length, grid[0].Length];

            int numberOfCountries = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (isCountry(grid, marked, i, j, grid[i][j]))
                    {
                        numberOfCountries++;
                    }
                }
            }

            return numberOfCountries;
        }


        private static bool isCountry(int[][] grid, bool[,] map, int r, int c, int x)
        {
            if (r < 0 || c < 0 || r >= grid.Length || c >= grid[0].Length || map[r, c] || grid[r][c] != x)
            {
                return false;
            }

            if (!map[r, c] && grid[r][c] == x)
            {
                map[r, c] = true;
                isCountry(grid, map, r - 1, c, grid[r][c]);
                isCountry(grid, map, r, c - 1, grid[r][c]);
                isCountry(grid, map, r + 1, c, grid[r][c]);
                isCountry(grid, map, r, c + 1, grid[r][c]);
            }

            return true;
        }


        /// <summary>
        ///     Test method to verify if the method works
        /// </summary>
        [TestMethod]
        public void NumOfCountriesTest()
        {
            int[][] grid1 = new int[][] { new int[] {6,5,4,4},
                                          new int[] {4,4,3,4},
                                          new int[] {1,3,2,4},
                                          new int[] {5,4,2,4},
                                          new int[] {9,4,3,4},
                                          new int[] {7,4,4,4},
                                          new int[] {1,4,4,4}, };
            int output = 13;

            char[][] grid2 = new char[][] {new char[] {'1', '1', '0', '0', '0'},
                                           new char[] {'1', '1', '0', '0', '0'},
                                           new char[] {'0', '0', '1', '0', '0'},
                                           new char[] {'0', '0', '0', '1', '1'}, };
            int output2 = 3;
            Assert.AreEqual(output, NumOfCountries(grid1));
        }
    }
}
