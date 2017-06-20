
namespace MethodsLibrary.Methods
{
    public class BinarySearch
    {

        /// <summary>
        /// This is my binary search template
        /// </summary>
        /// <param name="Target"> Target value to search </param>
        /// <param name="A"> Array of numbers </param>
        /// <returns> the index of the target in the array or the index of the first value less than target if the it's not found </returns>
        public static int myBinarySearch(int Target, int[] A)
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
                if (A[mid] == Target)
                {
                    return mid;
                }

                if (A[mid] > Target)
                {
                    end = mid - 1;
                }
                if (A[mid] < Target)
                {
                    start = mid + 1;
                }
            }
            // If the target value is not in the array
            // the end would be the index of the first value that's less than the target
            // the start would be the index of the first value that's greater than the target
            // That means the target should fall between A[end] and A[start] -- A[end] < Target < A[start]
            return A[end];
        }

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

    }
}
