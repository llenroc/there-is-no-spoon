namespace MethodsLibrary.Methods
{
    public class NumMatrix
    {
        private int[,] matrix { get; }

        public NumMatrix(int[,] matrix)
        {
            this.matrix = matrix;
        }

        public int SumRegion(int row1, int col1, int row2, int col2)
        {
            int sum = 0;
            if ((matrix == null) || (matrix.Length < row2) || (matrix.Length < col2))
            {
                return sum;
            }

            for (int i = row1; i <= row2; i++)
            {
                for (int j = col1; j <= col2; j++)
                {
                    sum = sum + matrix[i, j];
                }
            }

            return sum;
        }
    }
}