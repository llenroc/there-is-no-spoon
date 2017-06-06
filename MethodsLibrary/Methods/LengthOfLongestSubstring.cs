using System;
using System.Collections.Generic;

namespace MethodsLibrary.Methods
{
    public class LengthOfLongestSubstring
    {
        /// <summary>
        /// Given a string, find the length of the longest substring without repeating characters.
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <returns> Length of longest substring without repeating characters </returns>
        public static int lengthOfLongestSubstring(string s)
        {
            if ((s == null) || (s.Length == 0))
            {
                return 0;
            }

            int length = 1;
            int maxLength = 0;

            HashSet<char> set = new HashSet<char>();

            for (int i = 0; i < s.Length; i++)
            {
                set.Add(s[i]);
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (!set.Contains(s[j]))
                    {
                        length++;
                        set.Add(s[j]);
                    }
                    else
                    {
                        set.Clear();
                        break;
                    }
                }
                maxLength = maxLength > length ? maxLength : length; // Math.Max() should work too
                length = 1;
            }
            return maxLength;
        }

        /// <summary>
        /// Given a string, find the length of the longest substring without repeating characters.
        /// </summary>
        /// <param name="s"> Input string </param>
        /// <returns> Length of longest substring without repeating characters </returns>
        public static int lengthOfLongestSubstringRevised(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            int maxLength = 0;
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            for (int i = 0, j = 0; i < s.Length; ++i)
            {
                if (dictionary.ContainsKey(s[i]))
                {
                    j = Math.Max(j, dictionary[s[i]] + 1); // j is the index of the first char of this substring
                    dictionary[s[i]] = i;
                }
                else
                {
                    dictionary.Add(s[i], i);
                        // C# Dictionary can't handle duplicate keys or null keys like HashMap in Java
                }
                maxLength = Math.Max(maxLength, (i - j) + 1);
            }

            return maxLength;
        }
    }
}