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
            if (board == null || board.GetLength(0) == 0 || board.GetLength(1) == 0)
                return false;
            if (string.IsNullOrEmpty(word))
                return true;

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
            // OMG, I had a hard time troubleshooting why the test failed.
            // It tured out I used board.GetUpperBound() instead of board.GetLength()
            // Be careful with that next time 
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (isExist(board, i, j, word, 0)) return true;
                }
            }
            return false;
        }

        public static bool isExist(char[,] board, int row, int column, string word, int index)
        {
            if (index == word.Length) return true;
            if (row < 0 || row >= board.GetLength(0) || column < 0 || column >= board.GetLength(1) || word[index] != board[row, column]) return false;
            
            char temp = board[row, column];
            board[row, column] = '#';
            bool exist = isExist(board, row, column + 1, word, index + 1) ||
                         isExist(board, row, column - 1, word, index + 1) ||
                         isExist(board, row + 1, column, word, index + 1) ||
                         isExist(board, row - 1, column, word, index + 1);
            board[row, column] = temp;

            return exist;
        }
    }
}