namespace MethodsLibrary.Methods
{
    public class SearchA2DMatrix
    {
        public static bool SearchMatrix(int[,] matrix, int target)
        {
            if ((matrix.Length == 0) || (matrix == null) || ((matrix.Length == 1) && (matrix[0, 0] != target)))
            {
                return false;
            }
            int row = 0;
            int start = 0;
            int end = matrix.GetUpperBound(0);
            int left = 0;
            int right = matrix.GetUpperBound(1);
            while ((start + 1) < end)
            {
                int mid = start + ((end - start) / 2);
                if ((matrix[start, 0] == target) || (matrix[mid, 0] == target) || (matrix[end, 0] == target))
                {
                    return true;
                }
                if (matrix[mid, 0] < target)
                {
                    start = mid;
                }
                else if (matrix[mid, 0] > target)
                {
                    end = mid;
                }
            }

            //you would always want to find the greatest index of the element that's less than the target
            //so look for the end index first and it would end up at the same row where target lives
            if (matrix[end, 0] <= target)
            {
                row = end;
            }
            else if (matrix[start, 0] <= target)
            {
                row = start;
            }
            else
            {
                return false;
            }

            while ((left + 1) < right)
            {
                int mid = left + ((right - left) / 2);
                if ((matrix[row, left] == target) || (matrix[row, right] == target) || (matrix[row, mid] == target))
                {
                    return true;
                }
                if (matrix[row, mid] < target)
                {
                    left = mid;
                }
                else if (matrix[row, mid] > target)
                {
                    right = mid;
                }
            }
            if ((matrix[row, left] == target) || (matrix[row, right] == target))
            {
                return true;
            }
            return false;
        }

        // Treat is like an one dimensional array
        public static bool SearchMatrixRevised(int[,] matrix, int target)
        {
            var colCnt = matrix.GetLength(1);
            var low = 0;
            var high = matrix.Length - 1;
            while (low <= high)
            {
                var middle = (low + high) / 2;
                var midNum = matrix[middle / colCnt, middle % colCnt];
                if (midNum == target)
                {
                    return true;
                }
                if (midNum > target)
                {
                    high = middle - 1;
                }
                else
                {
                    low = middle + 1;
                }
            }
            return false;
        }

        //Search from greatest value
        public static bool SearchMatrixRevisedG(int[,] matrix, int target)
        {
            var m = matrix.GetLength(0);
            var n = matrix.GetLength(1);

            var i = 0;
            var j = n - 1;
            while ((j >= 0) && (i < m))
            {
                if (matrix[i, j] == target)
                {
                    return true;
                }
                if (matrix[i, j] > target)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }
            return false;
        }
    }
}