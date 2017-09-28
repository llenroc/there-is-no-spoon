
namespace MethodsLibrary.Methods
{
    public class WordSearch
    {
        public static bool Exist(char[,] board, string word)
        {




            return isExist(0, 0, 0, board, word);
        }

        public static bool isExist(int row, int column, int index, char[,] board, string word)
        {
            if (index == word.Length - 1)
            {
                return true;
            }
            int rows = board.GetUpperBound(0);
            int columns = board.GetUpperBound(1);
            if (row < 0 || row >= rows || column < 0 || column >= columns)
            {
                return false;
            }
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == board[row, column])
                {
                    isExist(row - 1, column, i, board, word);
                    isExist(row + 1, column, i, board, word);
                    isExist(row, column - 1, i, board, word);
                    isExist(row, column + 1, i, board, word);
                }
            }
            return false;
        }
    }
}
