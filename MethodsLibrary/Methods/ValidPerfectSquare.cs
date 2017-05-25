
namespace MethodsLibrary.Methods
{
    public class ValidPerfectSquare
    {
        public static bool IsPerfectSquare(int num)
        {
            if (num == 0)
            {
                return false;
            }
            long square = 1;
            while (square * square < num)
            {
                square *= 2;
            }
            if (square * square == num) return true;

            long left = square / 2;
            long right = square;
            while (left <= right)
            {
                long mid = left + (right - left) / 2;
                square = mid * mid;
                if (square == num)
                {
                    return true;
                }
                if (square < num)
                {
                    left = mid + 1;
                }
                if (square > num)
                {
                    right = mid - 1;
                }

            }
            return false;
        }
    }
}
