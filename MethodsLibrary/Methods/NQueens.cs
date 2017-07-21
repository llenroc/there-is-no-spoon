using System.Collections.Generic;
using System.Text;

namespace MethodsLibrary.Methods
{
    public class NQueens
    {
        public static IList<IList<string>> SolveNQueens(int n)
        {
            IList<IList<string>> solutions = new List<IList<string>>();
            if (n < 1)
            {
                return solutions;
            }
            IList<string> solution = new List<string>();

            Finding(solution, solutions, n, 0, 0);

            return solutions;
        }

        private static void Finding(IList<string> solution, IList<IList<string>> solutions, int n, int rows, int columns)
        {
            if (isLegit(solution, n))
            {
                solutions.Add(solution);
                return;
            }
            if (rows == n)
            {
                solution.Remove(solution[solution.Count - 1]);
                return;
            }
            for (int row = rows; row < n; row++)
            {
                StringBuilder sb = new StringBuilder();
                for (int index = 0; index < n; index ++)
                {
                    if (index == columns)
                    {
                        sb.Append("Q");
                        continue;
                    }
                    sb.Append(".");
                }
                solution.Add(sb.ToString());
                Finding(solution, solutions, n, ++rows, columns);
                
                columns++;
            }
        }

        public static bool isLegit(IList<string> chessBoard, int n)
        {
            if ((chessBoard == null) || (chessBoard.Count < n) || (chessBoard[0].Length < n))
            {
                return false;
            }
            // Check if every row has more than one Queen
            bool hasQueen;
            for (int i = 0; i < chessBoard.Count; i++)
            {
                hasQueen = false;
                for (int j = 0; j < chessBoard[i].Length; j++)
                {
                    if (chessBoard[i][j] == 'Q')
                    {
                        if (hasQueen)
                        {
                            return false;
                        }
                        hasQueen = true;
                    }
                }
            }
            // Check if every column has more than one Queen
            for (int i = 0; i < chessBoard[0].Length; i++)
            {
                hasQueen = false;
                for (int j = 0; j < chessBoard.Count; j++)
                {
                    if (chessBoard[j][i] == 'Q')
                    {
                        if (hasQueen)
                        {
                            return false;
                        }
                        hasQueen = true;
                    }
                }
            }
            // Check if diagonals have more than one Queen (upper right part)
            int rows = 0;
            int columns = 0;
            int v = 0;
            hasQueen = false;
            while (v < n)
            {
                rows = 0;
                while ((rows + v) < n)
                {
                    if (chessBoard[rows][rows + v] == 'Q')
                    {
                        if (hasQueen)
                        {
                            return false;
                        }
                        hasQueen = true;
                    }
                    rows++;
                }
                hasQueen = false;
                v++;
            }
            // Check if diagonals have more than one Queen (lower left part)
            rows = 1;
            columns = 0;
            v = 1;
            hasQueen = false;
            while (v < n)
            {
                int r = rows;
                while (r < n)
                {
                    if (chessBoard[r][r - v] == 'Q')
                    {
                        if (hasQueen)
                        {
                            return false;
                        }
                        hasQueen = true;
                    }
                    r++;
                }
                hasQueen = false;
                rows++;
                v++;
            }
            // Check if diagonals have more than one Queen (upper left part)
            rows = 0;
            columns = 0;
            v = 0;
            hasQueen = false;
            while (rows < n)
            {
                int r = rows;
                while (r >= 0)
                {
                    if (chessBoard[r][v - r] == 'Q')
                    {
                        if (hasQueen)
                        {
                            return false;
                        }
                        hasQueen = true;
                    }
                    r--;
                }
                hasQueen = false;
                rows++;
                v++;
            }
            // Check if diagonals have more than one Queen (lower right part)
            rows = 0;
            columns = 1;
            v = n;
            hasQueen = false;
            while (columns < n)
            {
                int c = columns;
                while (c < n)
                {
                    if (chessBoard[v - c][c] == 'Q')
                    {
                        if (hasQueen)
                        {
                            return false;
                        }
                        hasQueen = true;
                    }
                    c++;
                }
                hasQueen = false;
                columns++;
                v++;
            }
            return true;
        }
    }
}