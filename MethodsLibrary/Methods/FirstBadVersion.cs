using MethodsLibrary.Objects;

namespace MethodsLibrary.Methods
{
    public class FirstBadVersion : VersionControl
    {
        public static int firstBadVersion(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }

            int start = 1;
            while (start <= n)
            {
                //int version = (start + n) / 2; Avoid to calculate the sum of huge numbers.
                // You gotta remember this. It's just brilliant to reduce the calculation or avoid the overflow
                int version = start + ((n - start) / 2);
                if (IsBadVersion(version))
                {
                    n = version - 1;
                }
                else
                {
                    start = version + 1;
                }
            }
            return n + 1;
        }
    }
}