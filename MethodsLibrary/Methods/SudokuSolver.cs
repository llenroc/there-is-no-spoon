using System.Collections.Generic;

namespace MethodsLibrary.Methods
{
    public class SudokuSolver
    {
        public static void SolveSudoku(char[,] board)
        {
            if ((board == null) || (board.Length == 0))
            {
                return;
            }
            goSolver(board, 0, 0);
        }

        public static bool goSolver(char[,] board, int r, int c)
        {
            if (!isValidSudoku(board, r, c))
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
                            if (goSolver(board, row, column))
                            {
                                return true;
                            }
                                // The returned false comes from isValidSudoku(board)
                                // it means it's not a valid solution
                                // so set it back to '.' for the next try
                            board[row, column] = '.';
                        }
                        //When every number doesn't make it valid, it's a wrong path.
                        //Return false to get to the last calling and set it back to '.'
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Method to check if the sudoku board is valid
        /// </summary>
        /// <param name="board">2D array stands for the sudoku game board</param>
        /// <param name="r">Index of the row where the element is inserted</param>
        /// <param name="c">Index of the column where the element is inserted</param>
        /// <returns>True if the sudoku board is valid</returns>
        public static bool isValidSudoku(char[,] board, int r, int c)
        {
            if ((board == null) || (board.Length == 0))
            {
                return false;
            }

            HashSet<char> set = new HashSet<char>();

            // Check elements in the row
            for (int i = 0; i < 9; i++)
            {
                if (set.Contains(board[r, i]))
                {
                    return false;
                }
                if (board[r, i] != '.')
                {
                    set.Add(board[r, i]);
                }
            }
            set.Clear();
            // Check elements in each column
            for (int i = 0; i < 9; i++)
            {
                if (set.Contains(board[i, c]))
                {
                    return false;
                }
                if (board[i, c] != '.')
                {
                    set.Add(board[i, c]);
                }
            }
            set.Clear();
            // Check elements in each small square
            int row = r / 3;
            int column = c % 3;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (set.Contains(board[i + (row * 3), j + (column * 3)]))
                    {
                        //System.Console.WriteLine("Is it here?");
                        return false;
                    }
                    if (board[i + (row * 3), j + (column * 3)] != '.')
                    {
                        set.Add(board[i + (row * 3), j + (column * 3)]);
                    }
                }
            }
            return true;
        }

        // Following part uses the same method from Valid Sudoku
        // but it's checking the whole board which is slow
        // and this part requires to check if the board is filled
        // which costs more time. 
        // so it's ETL :( but easier to understand :)
        public static void goSolver2(char[,] board)
        {
            if (!isValidSudoku2(board))
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
                            if (done(board))
                            {
                                return;
                            }
                        }
                        board[row, column] = '.';
                        return;
                    }
                }
            }
        }

        private static bool done(char[,] board)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    if (board[row, column] == '.')
                    {
                        return false;
                    }
                }
            }
            return isValidSudoku2(board);
        }

        /// <summary>
        /// Method to check if the sudoku board is valid
        /// </summary>
        /// <param name="board">2D array stands for the sudoku game board</param>
        /// <returns>True if the sudoku board is valid</returns>
        public static bool isValidSudoku2(char[,] board)
        {
            if ((board == null) || (board.Length == 0))
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
                        if (set.Contains(board[i + (row * 3), j + (column * 3)]))
                        {
                            //System.Console.WriteLine("Is it here?");
                            return false;
                        }
                        if (board[i + (row * 3), j + (column * 3)] != '.')
                        {
                            set.Add(board[i + (row * 3), j + (column * 3)]);
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