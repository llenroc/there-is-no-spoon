
namespace MethodsLibrary.Methods
{
    public class BinarySearch
    {
        public static int upperBound(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0) return -1;
            int lb = -1, ub = nums.Length;
            while (lb + 1 < ub)
            {
                int mid = lb + (ub - lb) / 2;
                if (nums[mid] > target)
                {
                    ub = mid;
                }
                else
                {
                    lb = mid;
                }
            }

            return ub - 1;
        }

        public int binarySearch(int[] array, int target)
        {
            if (array == null || array.Length == 0)
            {
                return -1;
            }

            int start = 0, end = array.Length - 1;
            while (start + 1 < end)
            {
                int mid = start + (end - start) / 2;
                if (array[mid] == target)
                {
                    start = mid;
                }
                else if (array[mid] < target)
                {
                    start = mid;
                }
                else
                {
                    end = mid;
                }
            }
            if (array[start] == target)
            {
                return start;
            }
            if (array[end] == target)
            {
                return end;
            }
            return -1;
        }

        public static int myBinarySearch(int T, int[] A)
        {
            if (A == null || A.Length == 0)
            {
                return -1;
            }
            int start = 0;
            int end = A.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (A[mid] == T)
                {
                    return T;
                }

                if (A[mid] > T)
                {
                    end = mid - 1;
                }
                if (A[mid] < T)
                {
                    start = mid + 1;
                }
            }
            return A[end];
        }
    }
}
