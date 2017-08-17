
namespace MethodsLibrary.Methods
{
    public class SearchA2DMatrix
    {
        public static bool SearchMatrix(int[,] matrix, int target)
        {
            if (matrix.Length == 0 || matrix == null || (matrix.Length==1 && matrix[0,0]!=target))
            {
                return false;
            }
            int row = 0;
            int start = 0;
            int end = matrix.GetUpperBound(0);
            int left = 0;
            int right = matrix.GetUpperBound(1);
            while (start < end - 1)
            {
                int mid = start + (end - start) / 2;
                if(matrix[start, right] == target || matrix[mid, right] ==target || matrix[end, right] == target)
                {
                    return true;
                }
                else if(matrix[mid, right] <target)
                {
                    start = mid;
                }
                else if(matrix[mid, right] > target)
                {
                    end = mid;
                }
            }
            if (matrix[start, right] > target)
            {
                row = start;
            }
            else if(matrix[start, right] < target)
            {
                row = start + 1;
            }
            else if(matrix[end, right] > target)
            {
                row = end;
            }
            else if(matrix[end, right] < target)
            {
                row = end+1;
            }
            
            while (left < right - 1)
            {
                int mid = left + (right - left) / 2;
                if (matrix[row, left] == target || matrix[row, right] == target || matrix[row, mid] == target)
                {
                    return true;
                }
                else if (matrix[row, mid] < target)
                {
                    left = mid;
                }
                else if (matrix[row, mid] > target)
                {
                    right = mid;
                }
            }
            if (matrix[row, left] == target || matrix[row, right] == target)
            {
                return true;
            }
            return false;
        }
    }
}
