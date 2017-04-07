namespace MethodsLibrary.Methods
{
    public class LongestPalindromeSubstring
    {
        /// <summary>
        /// Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <returns> Longest palindromic substring </returns>
        public static string LongestPalindromeRevised(string s)
        {
            if ((s == null) || (s.Length < 2))
            {
                return s;
            }
            int maxIndex = 0;
            int maxLength = s.Length;

            while (maxLength > 1)
            {
                if (IsPalindromeRevised(s, maxIndex, maxIndex + maxLength - 1))
                {
                    return s.Substring(maxIndex, maxLength);
                }
                while (maxIndex <= (s.Length - maxLength))
                {
                    if (IsPalindromeRevised(s, maxIndex, maxIndex + maxLength - 1))
                    {
                        return s.Substring(maxIndex, maxLength);
                    }
                    maxIndex++;
                }
                maxIndex = 0;
                maxLength--;
            }
            return s.Substring(maxIndex, maxLength);
        }

        // Replaced Substring with index and it's much faster
        public static bool IsPalindromeRevised(string s, int head, int tail)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }
            while ((head <= tail) && (s[head] == s[tail]))
            {
                head++;
                tail--;
            }
            return head >= tail;
        }

        // Substring is too time consuming
        public static string LongestPalindrome(string s)
        {
            if ((s == null) || (s.Length < 2))
            {
                return s;
            }
            int maxIndex = 0;
            int maxLength = s.Length;

            while (maxLength > 1)
            {
                if (IsPalindrome(s.Substring(maxIndex, maxLength)))
                {
                    return s.Substring(maxIndex, maxLength);
                }
                while (maxIndex <= (s.Length - maxLength))
                {
                    if (IsPalindrome(s.Substring(maxIndex, maxLength)))
                    {
                        return s.Substring(maxIndex, maxLength);
                    }
                    maxIndex++;
                }
                maxIndex = 0;
                maxLength--;
            }

            return s.Substring(maxIndex, maxLength);
        }
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }
            //Console.WriteLine(s);
            int head = 0;
            int tail = s.Length - 1;
            while ((head <= tail) && (s[head] == s[tail]))
            {
                head++;
                tail--;
            }
            return head >= tail;
        }
    }
}