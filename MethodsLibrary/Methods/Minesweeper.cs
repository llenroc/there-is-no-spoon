


namespace MethodsLibrary.Methods
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Minesweeper
    {

        [TestMethod]
        public void MinesweeperTet()
        {
            char[][] board = new char[][]
            {
                new char[] {'E', 'E', 'E', 'E', 'E'},
                new char[] {'E', 'E', 'M', 'E', 'E'},
                new char[] {'E', 'E', 'E', 'E', 'E'},
                new char[] {'E', 'E', 'E', 'E', 'E'}
            };

            int[] click = new int[] { 3, 0 };



            char[][] board2 = new char[][]
{
                new char[] {'B', '1', 'E', '1', 'B'},
                new char[] {'B', '1', 'X', '1', 'B'},
                new char[] {'B', '1', '1', '1', 'B'},
                new char[] {'B', 'B', 'B', 'B', 'B'}
};

            int[] click2 = new int[] { 1, 2 };

            char[][] board3 = new char[][]
{
                new char[] { 'E','E','E','E','E','E','E','E'},
                new char[] { 'E','E','E','E','E','E','E','M'},
                new char[] { 'E','E','M','E','E','E','E','E'},
                new char[] { 'M','E','E','E','E','E','E','E'},
                new char[] { 'E','E','E','E','E','E','E','E'},
                new char[] { 'E','E','E','E','E','E','E','E'},
                new char[] { 'E','E','E','E','E','E','E','E'},
                new char[] { 'E','E','M','M','E','E','E','E'}
};

            int[] click3 = new int[] { 0, 0 };

            /*
                [
                ["B","B","B","B","B","B","1","E"],
                ["B","1","1","1","B","B","1","M"],
                ["1","2","M","1","B","B","1","1"],
                ["M","2","1","1","B","B","B","B"],
                ["1","1","B","B","B","B","B","B"],
                ["B","B","B","B","B","B","B","B"],
                ["B","1","2","2","1","B","B","B"],
                ["B","1","M","M","1","B","B","B"]
                ]
             
             */



            UpdateBoard(board3, click3);

            for (int i = 0; i < board3.Length; i++)
            {
                for (int j = 0; j < board3[0].Length; j++)
                {
                    Console.Write(board3[i][j] + ", " + "\t");
                }
                Console.WriteLine();
            }

        }

        public char[][] UpdateBoard(char[][] board, int[] click)
        {
            if (board[click[0]][click[1]] == 'M')
            {
                board[click[0]][click[1]] = 'X';
                return board;
            }

            play(board, click[0], click[1]);

            return board;
        }

        public void play(char[][] board, int r, int c)
        {
            if (r < 0 || r >= board.Length || c < 0 || c >= board[0].Length || board[r][c] != 'E')
            {
                return;
            }

            int numOfMinesAround = 0;
            if (r - 1 >= 0 && c - 1 >= 0 && r - 1 < board.Length && c - 1 < board[0].Length && board[r - 1][c - 1] == 'M')
            {
                numOfMinesAround++;
            }
            if (r >= 0 && c - 1 >= 0 && r < board.Length && c - 1 < board[0].Length && board[r][c - 1] == 'M')
            {
                numOfMinesAround++;
            }
            if (r + 1 >= 0 && c - 1 >= 0 && r + 1 < board.Length && c - 1 < board[0].Length && board[r + 1][c - 1] == 'M')
            {
                numOfMinesAround++;
            }
            if (r + 1 >= 0 && c >= 0 && r + 1 < board.Length && c < board[0].Length && board[r + 1][c] == 'M')
            {
                numOfMinesAround++;
            }
            if (r + 1 >= 0 && c + 1 >= 0 && r + 1 < board.Length && c + 1 < board[0].Length && board[r + 1][c + 1] == 'M')
            {
                numOfMinesAround++;
            }
            if (r >= 0 && c + 1 >= 0 && r < board.Length && c + 1 < board[0].Length && board[r][c + 1] == 'M')
            {
                numOfMinesAround++;
            }
            if (r - 1 >= 0 && c + 1 >= 0 && r - 1 < board.Length && c + 1 < board[0].Length && board[r - 1][c + 1] == 'M')
            {
                numOfMinesAround++;
            }
            if (r - 1 >= 0 && c >= 0 && r - 1 < board.Length && c < board[0].Length && board[r - 1][c] == 'M')
            {
                numOfMinesAround++;
            }

            if (numOfMinesAround != 0)
            {
                board[r][c] = (char)(numOfMinesAround + 48); //(char)('0' + mineCount);
                return;
            }

            board[r][c] = 'B';

            play(board, r - 1, c);
            play(board, r - 1, c - 1);
            play(board, r, c - 1);
            play(board, r + 1, c - 1);
            play(board, r + 1, c);
            play(board, r + 1, c + 1);
            play(board, r, c + 1);
            play(board, r - 1, c + 1);

            return;
        }


    }
}
