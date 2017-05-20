
namespace MethodsLibrary.Methods
{
    public class ClosestNumbers
    {
        public static int[] closestNumbers(int T, int K, int[] A)
        {
            if(A==null || A.Length<0)
            {
                return null;
            }
            int[] result = new int[K];
            int index = 0;
            int start = 0;
            int end = A.Length-1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if(A[mid] == T)
                {
                    result[index++] = A[mid];
                    end = mid - 1;
                    start = mid + 1;
                    break;
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
            while(index<K)
            {
                if(end < 0)
                {
                    result[index++] = A[start++];
                    continue;
                }
                else if(start >= A.Length) {
                    result[index++] = A[end--];
                    continue;
                }
                else
                {
                    if (T - A[end] <= A[start] - T)
                    {
                        result[index++] = A[end--];
                    }
                    else
                    //if (T - A[end] > A[start] - T)
                    {
                        result[index++] = A[start++];
                    }
                }
            }
            
            return result;
        }
    }
}