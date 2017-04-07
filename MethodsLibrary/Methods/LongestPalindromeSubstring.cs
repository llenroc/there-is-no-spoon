namespace MethodsLibrary.Methods
{
    public class LongestPalindromeSubstring
    {
        public static string LongestPalindrome(string s)
        {
            if ((s == null) || (s.Length < 2))
            {
                return s;
            }
            int maxIndex = 0;
            int maxLength = s.Length;

            while (maxLength >= 0)
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