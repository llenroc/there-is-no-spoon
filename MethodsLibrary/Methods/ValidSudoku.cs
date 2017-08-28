
using System.Collections.Generic;

namespace MethodsLibrary.Methods
{
    public class ValidSudoku
    {
        public static bool IsValidSudoku(char[,] board)
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
                        System.Console.WriteLine("Is it here? row");
                        return false;
                    }
                    if(board[i, j]!='.')
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
                        System.Console.WriteLine("Is it here? column");
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
                            System.Console.WriteLine("Is it here?");
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
