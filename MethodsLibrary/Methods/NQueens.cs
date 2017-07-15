using System;
using System.Collections.Generic;

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
            IList<string> solution = new List<string>
            {
                "....",
                "....",
                "....",
                "...."
            };

            Finding(solution, solutions, n, 0);

            return solutions;
        }

        private static void Finding(IList<string> solution, IList<IList<string>> solutions, int n, int v)
        {
            if (v == n && isLegit(solution))
            {
                solutions.Add(solution);
                return;
            }
            for (int i=0; i<n; i++)
            {
                
            }
        }
        
        public static bool isLegit(IList<string> chessBoard)
        {
            if (chessBoard == null)
            {
                return false;
            }
            // Check if every row has more than one Queue
            for (int i = 0; i < chessBoard.Count; i++)
            {
                bool hasQueen = false;
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
            // Check if every column has more than one Queue
            for (int i = 0; i < chessBoard[0].Length; i++)
            {
                bool hasQueen = false;
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
            return true;
        }
    }
}