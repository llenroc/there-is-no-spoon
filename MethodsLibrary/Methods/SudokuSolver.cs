using System.Collections.Generic;

namespace MethodsLibrary.Methods
{
    public class SudokuSolver
    {
        public static void SolveSudoku(char[,] board)
        {
            if (board == null || board.Length == 0)
            {
                return;
            }
            if (!isValidSudoku(board))
            {
                return;
            }
            goSolver2(board);
        }

        public static bool goSolver(char[,] board)
        {
            if (!isValidSudoku(board))
            {
                return false;
            }
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    if (board[row, column] == '.')
                    {
                        for (char n = '1'; n <= '9'; n++)
                        {
                            //board[row, column] = Convert.ToChar(n + 48); Use this if the n is int
                            board[row, column] = n;
                            if (goSolver(board))
                            {
                                return true;
                            }
                            // The returned false comes from isValidSudoku(board)
                            // it means it's not a valid solution
                            // so set it back to '.' for the next try
                            else
                            {
                                board[row, column] = '.';
                            }
                        }
                        //When every number doesn't make it valid, it's a wrong path.
                        //Return false to get to the last calling and set it back to '.'
                        return false;
                    }
                }
            }
            return true;
        }

        public static void goSolver2(char[,] board)
        {
            if (!isValidSudoku(board))
            {
                return;
            }
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    if (board[row, column] == '.')
                    {
                        for (char n = '1'; n <= '9'; n++)
                        {
                            //board[row, column] = Convert.ToChar(n + 48); Use this if the n is int
                            board[row, column] = n;
                            goSolver2(board);                
                        }
                        board[row, column] = '.';
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Method to check if the sudoku board is valid
        /// </summary>
        /// <param name="board">2D array stands for the sudoku game board</param>
        /// <returns>True if the sudoku board is valid</returns>
        public static bool isValidSudoku(char[,] board)
        {
            if (board == null || board.Length == 0)
            {
                return false;
            }

            HashSet<char> set = new HashSet<char>();

            // Check elements in each row
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (set.Contains(board[i, j]))
                    {
                        //System.Console.WriteLine("Is it here? row");
                        return false;
                    }
                    if (board[i, j] != '.')
                    {
                        set.Add(board[i, j]);
                    }
                }
                set.Clear();
            }

            // Check elements in each column
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (set.Contains(board[j, i]))
                    {
                        //System.Console.WriteLine("Is it here? column");
                        return false;
                    }
                    if (board[j, i] != '.')
                    {
                        set.Add(board[j, i]);
                    }
                }
                set.Clear();
            }

            // Check elements in each small square
            int s = 0;
            while (s < 9)
            {
                int row = s / 3;
                int column = s % 3;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (set.Contains(board[i + row * 3, j + column * 3]))
                        {
                            //System.Console.WriteLine("Is it here?");
                            return false;
                        }
                        if (board[i + row * 3, j + column * 3] != '.')
                        {
                            set.Add(board[i + row * 3, j + column * 3]);
                        }

                    }
                }
                set.Clear();
                s++;
            }

            return true;
        }
    }
}
