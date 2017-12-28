namespace MethodsLibrary.Methods
{
    public class WordSearch
    {
        public static bool Exist(char[,] board, string word)
        {
            if ((board == null) || (board.GetLength(0) == 0) || (board.GetLength(1) == 0))
                return false;
            if (string.IsNullOrEmpty(word))
                return true;

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
            if ((row < 0) || (row >= board.GetLength(0)) || (column < 0) || (column >= board.GetLength(1)) ||
                (word[index] != board[row, column])) return false;

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