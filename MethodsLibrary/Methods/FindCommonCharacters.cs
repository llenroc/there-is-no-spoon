
namespace MethodsLibrary.Methods
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;

    [TestClass]
    public class FindCommonCharacters
    {
        public IList<string> CommonChars(string[] A)
        {

            //Input: ["bellaoo","laabelo","rolleroo"]
            //Output: ["e", "l", "l", "o"]

            // initialize the array for minimum frequency of each letter using the first string
            int[] minFreq = new int[26];
            for (int i=0; i<A[0].Length; i++)
            {
                ++minFreq[A[0][i] - 'a'];
            }
            
            // iterate through strings 
            int n = 1;
            while (n < A.Length)
            {
                string s = A[n];
                // iterate through the charaters of each string and record the frequency of each character
                int[] freq = new int[26];
                for (int i = 0; i < s.Length; i++)
                {
                    ++freq[s[i] - 'a'];
                }
                // take record of the minimum frequency of each letter  (for handling duplicates)
                for (int i=0; i<26; i++)
                {
                    minFreq[i] = Math.Min(minFreq[i], freq[i]);
                }
                n++;
            }

            // populate the result list using the minimun frequency array.
            IList<string> result = new List<string>();
            for (int i=0; i<26; i++)
            {
                while(minFreq[i] != 0)
                {
                    //char c = Convert.ToChar(i + 'a');
                    //string s = c.ToString();
                    //result.Add(s);
                    result.Add(((char) ('a' + i) + ""));
                    minFreq[i]--;
                }
            }

            return result;
        }

        [TestMethod]
        public void CommonCharsTest()
        {
            string[] input1 = new string[] { "bellaoo", "laabelo", "rolleroo" };
            var result = CommonChars(input1);

            foreach(var s in result)
            {
                Console.WriteLine(s);
            }
        }
    }
}
