namespace MethodsLibrary.Methods
{
    using System;

    public class WordSearch
    {
        public static bool Exist(char[,] board, string word)
        {
            int rows = board.GetUpperBound(0);
            int columns = board.GetUpperBound(1);
            int index = 0;
            bool isExisted = false;
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    if (isExisted) return true;

                    if (word[index] == board[row, column])
                    {
                        isExisted = IsExist(row, column, 0, rows, columns, board, word);
                    }
                }
            }

            return isExisted;
        }

        public static bool IsExist(int row, int column, int rows, int columns, int index, char[,] board, string word)
        {
            Console.Write(board[row,column]);
            if ((word[index] != board[row, column]) || (row < 0) || (row >= rows) || (column < 0) ||
                (column >= columns))
            {
                return false;
            }

            if (index == (word.Length - 1))
            {
                return true;
            }

            //for (int i = row; i < rows; i++)
            //{
            //    for (int j = column; j < columns; j++)
            //    {
            //        if (word[index] == board[i, j])
            //        {
            //            return IsExist(row - 1, column, index + 1, rows, columns, board, word) ||
            //                   IsExist(row + 1, column, index + 1, rows, columns, board, word) ||
            //                   IsExist(row, column - 1, index + 1, rows, columns, board, word) ||
            //                   IsExist(row, column + 1, index + 1, rows, columns, board, word);
            //        }
            //    }
            //}

            //return false;

            return IsExist(row, column - 1, index + 1, rows, columns, board, word) ||
                   IsExist(row - 1, column, index + 1, rows, columns, board, word) ||
                   IsExist(row, column + 1, index + 1, rows, columns, board, word) ||
                   IsExist(row + 1, column, index + 1, rows, columns, board, word);
        }
    }
}