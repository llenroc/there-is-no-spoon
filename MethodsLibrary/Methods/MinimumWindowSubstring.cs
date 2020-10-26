namespace MethodsLibrary.Methods
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class MinimumWindowSubstring
    {
        public string MinWindow(string s, string t)
        {
            if (s == null || s.Length == 0 || t == null|| t.Length == 0)
            {
                return "";
            }

            Dictionary<char, int> target = new Dictionary<char, int>();

            foreach (char c in t)
            {
                if (target.ContainsKey(c))
                    target[c]++;
                else
                    target.Add(c, 1);
            }

            int left = 0, right = 0, minlen = s.Length + 1, counter = target.Count;
            string res = "";

            while (right < s.Length)
            {
                char rightChar = s[right];
                if (target.ContainsKey(rightChar))
                {
                    target[rightChar]--;
                    if (target[rightChar] == 0)
                        counter--;
                }
                right++;

                while (counter == 0)
                {
                    if (right - left < minlen)
                    {
                        minlen = right - left;
                        res = s.Substring(left, minlen);
                    }
                    char leftChar = s[left];
                    if (target.ContainsKey(leftChar))
                    {
                        target[leftChar]++;
                        if (target[leftChar] > 0)
                            counter++;
                    }
                    left++;
                }
            }

            return res;
        }

        [TestMethod]
        public void MinWindowTest()
        {
            string s = "ADOBECODEBANC";
            string t = "ABC";
            string output = "BANC";
            Assert.AreEqual(MinWindow(s, t), output);
        }
    }
}
