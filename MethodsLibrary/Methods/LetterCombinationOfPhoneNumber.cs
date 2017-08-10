using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                { '7', "pqr" },
                { '8', "tuv" },
                { '9', "wxyz" },
                { '0', " " },
                { '*', "" },
                { '#', "" }
            };

            

            return result;
        }

        
    }
}
