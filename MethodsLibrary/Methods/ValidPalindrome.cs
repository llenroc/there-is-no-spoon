
namespace MethodsLibrary.Methods
{
    public class ValidPalindrome
    {
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            s.Trim();
            s.ToLower();
            int start = 0;
            int end = s.Length - 1;

            while (start < end)
            {
                if (!char.IsLetter(s[start]))
                {
                    start++;
                }
                if (!char.IsLetter(s[end]))
                {
                    end--;
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
    }
}
