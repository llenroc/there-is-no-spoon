


namespace MethodsLibrary.Methods
{

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DecodeWays
    {
        //https://leetcode.com/problems/decode-ways/discuss/30451/Evolve-from-recursion-to-dp

        // Recursion O(2^n). A char may be decoded alone or by pairing with the next char.
        /*
        public int NumDecodings(string s)
        {
            if(s==null || s.Length == 0)
            {
                return 0;
            }
            return numDecodings(0, s);
        }

        private int numDecodings(int p, string s)
        {
            int n = s.Length;
            if (p == n) return 1;
            if (s[p] == '0') return 0;
            int res = numDecodings(p + 1, s);
            if (p < n - 1 && (s[p] == '1' || s[p] == '2' && s[p + 1] < '7'))
                res += numDecodings(p + 2, s);
            return res;
        }
        */


        // O(n) Memo
        /*
        public int numDecodings(String s)
        {
            int n = s.length();
            Integer[] mem = new Integer[n];
            return s.length() == 0 ? 0 : numDecodings(0, s, mem);
        }
        private int numDecodings(int p, String s, Integer[] mem)
        {
            int n = s.length();
            if (p == n) return 1;
            if (s.charAt(p) == '0') return 0;
            if (mem[p] != null) return mem[p];
            int res = numDecodings(p + 1, s, mem);
            if (p < n - 1 && (s.charAt(p) == '1' || s.charAt(p) == '2' && s.charAt(p + 1) < '7'))
                res += numDecodings(p + 2, s, mem);
            return mem[p] = res;
        }
        */

        // DP O(n) time and space, this can be converted from #2 with copy and paste.
        public int NumDecodings(string s)
        {
            int n = s.Length;
            int[] dp = new int[n + 1];
            dp[n] = 1;
            for (int i = n - 1; i >= 0; i--)
                if (s[i] != '0')
                {
                    dp[i] = dp[i + 1];
                    if (i < n - 1 && (s[i] == '1' || s[i] == '2' && s[i+1] < '7'))
                        dp[i] += dp[i + 2];
                }
            return dp[0];
        }

        // DP constant space
        /*
        public int numDecodings(String s)
        {
            int dp1 = 1, dp2 = 0, n = s.length();
            for (int i = n - 1; i >= 0; i--)
            {
                int dp = s.charAt(i) == '0' ? 0 : dp1;
                if (i < n - 1 && (s.charAt(i) == '1' || s.charAt(i) == '2' && s.charAt(i + 1) < '7'))
                    dp += dp2;
                dp2 = dp1;
                dp1 = dp;
            }
            return dp1;
        }
        */

        // My recursion 
        /*
        public int NumDecodings(string s)
        {
            if (s == null || s.Length == 0)
            {
                return 0;
            }
            return numDecodings(0, s);
        }

        private int numDecodings(int p, string s)
        {
            int n = s.Length;
            if (p == n) return 1;
            if (s[p] == '0') return 0;
            int res = numDecodings(p + 1, s);
            if (p < n - 1 && (s[p] == '1' || s[p] == '2' && s[p + 1] < '7'))
                res += numDecodings(p + 2, s);
            return res;
        }
        */

        [TestMethod]
        public void NumDecodingsTest()
        {
            string input1 = "2320"; //"12321" "102" "230"
            int output1 = 2; //Explanation: It could be decoded as "AB" (1 2) or "L" (12).

            string input2 = "226";
            int output2 = 3; //Explanation: It could be decoded as "BZ" (2 26), "VF" (22 6), or "BBF" (2 2 6).

            // "1234" => "ABCD", "LCD" , "AWD"
            // "12326241"

            var output = NumDecodings(input1);


            System.Console.WriteLine(output);


        }
    }
}
