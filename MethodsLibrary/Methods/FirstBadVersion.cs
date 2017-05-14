using MethodsLibrary.Objects;


namespace MethodsLibrary.Methods
{
    public class FirstBadVersion : VersionControl
    {
        public static int firstBadVersion(int n)
        {
            if (n==0 || n==1)
            {
                return n;
            }

            int start = 1; 
            int version = 0;
            while (start <= n)
            {
                version = (start + n) / 2;
                if(IsBadVersion(version))
                {
                    n = version - 1;
                }
                else
                {
                    start = version + 1;
                }
            }
            return n;
        }
    }



}
