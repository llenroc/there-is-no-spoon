namespace MethodsLibrary.Methods
{
    public class ValidPalindrome
    {
        /// <summary>
        ///     Mine works, but not looks silly
        /// </summary>
        /// <param name="s">Input string for checking</param>
        /// <returns>If the string is palindrome</returns>
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            s = s.ToLower();
            int start = 0;
            int end = s.Length - 1;

            while (start < end)
            {
                while ((start < s.Length) && !char.IsLetterOrDigit(s[start]))
                {
                    start++;
                }
                while ((end >= 0) && !char.IsLetterOrDigit(s[end]))
                {
                    end--;
                }
                if ((start >= s.Length) || (end < 0))
                {
                    break;
                }

                if (s[start] != s[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }

        /// <summary>
        ///     I admit this is better than mine up there. Mine is just too... silly
        /// </summary>
        /// <param name="s">Input string for checking</param>
        /// <returns>If the string is palindrome</returns>
        public static bool IsPalindromeG(string s)
        {
            s = s.ToLower();
            int head = 0;
            int end = s.Length - 1;

            while (head <= end)
            {
                while ((head < end) && !isAlphaNum(s[head]))
                    head++;
                while ((end > head) && !isAlphaNum(s[end]))
                    end--;

                if (s[head] != s[end])
                    return false;

                head++;
                end--;
            }

            return true;
        }

        private static bool isAlphaNum(char c)
        {
            return ((c <= 'z') && (c >= 'a')) || ((c <= '9') && (c >= '0'));
        }
    }
}