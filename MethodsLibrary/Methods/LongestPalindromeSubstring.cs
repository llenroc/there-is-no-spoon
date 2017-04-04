using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MethodsLibrary.Methods
{
    public class LongestPalindromeSubstring
    {
        public static string LongestPalindrome(string s)
        {
            string result = null;


            return result;
        }

        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }
            int head = 0;
            int tail = s.Length-1;
            while ((head<=tail) && (s[head]==s[tail]))
            {
                head++;
                tail--;
            }
            return head >= tail;
        }
    }
}
