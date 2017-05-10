using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MethodsLibrary.Methods
{
    public class ReverseWordsInAString
    {
        // Use string.IsNullOrWhiteSpace to skip the whitespaces in the string when build the result string
        public static string ReverseWords(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            s = s.Trim();
            string[] strings = s.Split(' ');
            StringBuilder sb = new StringBuilder();
            for (int i= strings.Length-1; i>=0; i--) 
            {
                if (string.IsNullOrWhiteSpace(strings[i]))
                {
                    continue;
                }
                sb.Append(strings[i]).Append(' ');
            }
            return sb.ToString().Trim();
        }

        // Use regular expression to split the string to skip the whitespaces in the string
        public static string ReverseWordsG(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            s = s.Trim();
            string[] strings = Regex.Split(s, @"\s+");
            StringBuilder sb = new StringBuilder();
            for (int i = strings.Length - 1; i >= 0; i--)
            {
                sb.Append(strings[i]).Append(' ');
            }
            return sb.ToString().Trim();
        }

        //Use StringSplitOptions.RemoveEmptyEntries to skip the whitespaces in the string
        public static string ReverseWordsGG(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            char[] whitespace = { ' '};
            string[] strings = s.Trim().Split(whitespace, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();
            for (int i = strings.Length - 1; i >= 0; i--)
            {
                sb.Append(strings[i]).Append(' ');
            }
            return sb.ToString().Trim();
        }
    }
}
