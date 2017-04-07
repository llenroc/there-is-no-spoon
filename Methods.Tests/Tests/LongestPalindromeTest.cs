using System;
using System.Collections.Generic;
using Methods.Tests.Objects;
using MethodsLibrary.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods.Tests.Tests
{
    [TestClass]
    public class LongestPalindromeTest
    {
        /// <summary>
        /// List to store test data set
        /// </summary>
        public List<LongestPalindromeTestData> TestDataList { set; get; }

        /// <summary>
        /// Initialize test data
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            TestDataList = new List<LongestPalindromeTestData>
            {
                new LongestPalindromeTestData
                {
                    InputString = "",
                    OutputString = ""
                },
                new LongestPalindromeTestData
                {
                    InputString = "xx",
                    OutputString = "xx"
                },
                new LongestPalindromeTestData
                {
                    InputString = "ab",
                    OutputString = "a"
                },
                new LongestPalindromeTestData
                {
                    InputString = "xxxxa",
                    OutputString = "xxxx"
                },
                new LongestPalindromeTestData
                {
                    InputString = "xxxxaxxs",
                    OutputString = "xxaxx"
                },
                new LongestPalindromeTestData
                {
                    InputString = "x",
                    OutputString = "x"
                },
                new LongestPalindromeTestData
                {
                    InputString = "abba",
                    OutputString = "abba"
                },
                new LongestPalindromeTestData
                {
                    InputString = "babad",
                    OutputString = "bab"
                },
                new LongestPalindromeTestData
                {
                    InputString = "cbbd",
                    OutputString = "bb"
                }
                //,
                //new LongestPalindromeTestData
                //{
                //    InputString = "zudfweormatjycujjirzjpyrmaxurectxrtqedmmgergwdvjmjtstdhcihacqnothgttgqfywcpgnuvwglvfiuxteopoyizgehkwuvvkqxbnufkcbodlhdmbqyghkojrgokpwdhtdrwmvdegwycecrgjvuexlguayzcammupgeskrvpthrmwqaqsdcgycdupykppiyhwzwcplivjnnvwhqkkxildtyjltklcokcrgqnnwzzeuqioyahqpuskkpbxhvzvqyhlegmoviogzwuiqahiouhnecjwysmtarjjdjqdrkljawzasriouuiqkcwwqsxifbndjmyprdozhwaoibpqrthpcjphgsfbeqrqqoqiqqdicvybzxhklehzzapbvcyleljawowluqgxxwlrymzojshlwkmzwpixgfjljkmwdtjeabgyrpbqyyykmoaqdambpkyyvukalbrzoyoufjqeftniddsfqnilxlplselqatdgjziphvrbokofvuerpsvqmzakbyzxtxvyanvjpfyvyiivqusfrsufjanmfibgrkwtiuoykiavpbqeyfsuteuxxjiyxvlvgmehycdvxdorpepmsinvmyzeqeiikajopqedyopirmhymozernxzaueljjrhcsofwyddkpnvcvzixdjknikyhzmstvbducjcoyoeoaqruuewclzqqqxzpgykrkygxnmlsrjudoaejxkipkgmcoqtxhelvsizgdwdyjwuumazxfstoaxeqqxoqezakdqjwpkrbldpcbbxexquqrznavcrprnydufsidakvrpuzgfisdxreldbqfizngtrilnbqboxwmwienlkmmiuifrvytukcqcpeqdwwucymgvyrektsnfijdcdoawbcwkkjkqwzffnuqituihjaklvthulmcjrhqcyzvekzqlxgddjoir",
                //    OutputString = "bb"
                //}
            };
        }

        /// <summary>
        /// Test method to verify if the method works
        /// </summary>
        [TestMethod]
        public void longestPalindromeTest()
        {
            foreach (LongestPalindromeTestData testData in TestDataList)
            {
                Console.WriteLine("Testing => Input: " + testData.InputString + "; Expected Output: " +
                                  testData.OutputString);
                Assert.AreEqual(LongestPalindromeSubstring.LongestPalindrome(testData.InputString),
                                testData.OutputString, "Failed on the case: " + testData.InputString);
            }
        }
    }
}