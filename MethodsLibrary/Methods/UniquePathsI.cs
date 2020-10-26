

namespace MethodsLibrary.Methods
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UniquePathsI
    {
        public int UniquePaths(int m, int n)
        {
            if (m == 1 || n == 1)
            {
                return 1;
            }

            // initialize the default values
            int[,] paths = new int[m, n];
            //for(int i=0; i<m; i++)
            //{
            //    paths[i, 0] = 1;
            //}
            //for(int i=0; i<n; i++)
            //{
            //    paths[0, i] = 1;
            //}

            for (int r = 1; r < m; r++)
            {
                paths[r, 0] = 1;
                for (int c = 1; c < n; c++)
                {
                    paths[0, c] = 1;
                    paths[r, c] = paths[r - 1, c] + paths[r, c - 1];
                }
            }

            return paths[m - 1, n - 1];

        }
        /*
            public int UniquePaths(int m, int n) {
        return UniquePathRec(m,n);
    }
    
    public static int[,] cache = new int[101,101];
    public int UniquePathRec(int m, int n){
        if(cache[m,n] != 0) return cache[m,n];
        if(m==1) return 1;
        if(n==1) return 1;
        cache[m,n] = UniquePathRec(m-1,n) + UniquePathRec(m,n-1);
        return cache[m,n];
    }           
             
        */

        [TestMethod]
        public void UniquePathsTest()
        {
            int m = 3, n = 2;
            int output = 3;

            System.Console.WriteLine(UniquePaths(m, n));

            int m2 = 7, n2 = 3;
            int output2 = 28;
            System.Console.WriteLine(UniquePaths(m2, n2));

            int m3 = 1, n3 = 2;
            int output3 = 1;
            System.Console.WriteLine(UniquePaths(m3, n3));
        }

    }
}
