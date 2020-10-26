
namespace MethodsLibrary.Methods
{
    public class NumberOfIslands
    {
        // This could be done in-place. 
        // Just turn '1's into '0's to mark it as visited.
        private static bool[,] marked;

        public static int NumIslands(char[][] grid)
        {
            if(grid == null || grid.Length == 0)
            {
                return 0;
            }

            marked = new bool[grid.Length, grid[0].Length];

            int numberOfIslands = 0;

            for(int i = 0; i < grid.Length; i++)
            {
                for(int j = 0; j<grid[0].Length; j++)
                {
                    if (isLand(grid, marked, i, j))
                    {
                        numberOfIslands++;
                    }
                }
            }

            return numberOfIslands;
        }

        private static bool isLand(char[][] grid, bool[,] map, int r, int c)
        {
            if(r<0 || c<0 || r>=grid.Length || c>=grid[0].Length || map[r, c] || grid[r][c] != '1')
            {
                return false;
            }

            if (map[r, c] == false && grid[r][c] == '1')
            {
                map[r, c] = true;
                isLand(grid, map, r - 1, c);
                isLand(grid, map, r, c - 1);
                isLand(grid, map, r + 1, c);
                isLand(grid, map, r, c + 1);
            }

            return true;
        }
    }
}
