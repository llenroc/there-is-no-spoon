
namespace MethodsLibrary.Methods
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class LongestCommonPrefix
    {
        public string LongestCommonPrefixX(string[] strs)
        {
            if(strs ==  null || strs.Length == 0)
            {
                return "";
            }

            int char_index = 0;
            while (char_index < strs[0].Length)
            {
                for (int strs_i = 1; strs_i < strs.Length; strs_i++)
                {
                    if(char_index >= strs[strs_i].Length || strs[0][char_index] != strs[strs_i][char_index])
                    {
                        return strs[0].Substring(0, char_index); 
                    }
                }
                char_index++;
            } 

            return strs[0].Substring(0, char_index);
        }

        [TestMethod]
        public void LongestCommonPrefixTest()
        {
            string[] input = new string[] { "flower","flow","flight", "j" };

            foreach (var s in input)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(LongestCommonPrefixX(input));

        }
    }
}
