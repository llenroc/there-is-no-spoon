﻿using System.Collections.Generic;
using System.Text;

namespace MethodsLibrary.Methods
{
    public class LetterCombinationOfPhoneNumber
    {
        //Input:Digit string "23"
        //Output: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].
        public static IList<string> LetterCombinations(string digits)
        {
            IList<string> result = new List<string>();

            if(digits == null || digits.Length == 0)
            {
                return result;
            }

            Dictionary<char, string> panel = new Dictionary<char, string>
            {
                { '1', "" },
                { '2', "abc" },
                { '3', "def" },
                { '4', "ghi" },
                { '5', "jkl" },
                { '6', "mno" },
                { '7', "pqrs" },
                { '8', "tuv" },
                { '9', "wxyz" },
                { '0', " " },
                { '*', "" },
                { '#', "" }
            };

            combination(digits, panel, result, new StringBuilder(), 0);

            return result;
        }

        public static void combination (string digits, Dictionary<char, string> panel, IList<string> result, StringBuilder sb, int n)
        {
            if(sb.Length == digits.Length)
            {
                result.Add(sb.ToString());
                return;
            }

            string s = panel[digits[n]];

            for(int i=0; i<s.Length; i++)
            {
                sb.Append(s[i]);
                combination(digits, panel, result, sb, n+1);
                sb.Remove(sb.Length-1,1);
            }
        }
    }
}
