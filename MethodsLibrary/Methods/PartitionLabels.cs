namespace MethodsLibrary.Methods
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;

    [TestClass]
    public class PartitionLabelsClass
    {

        public IList<int> PartitionLabels(string S)
        {
            // There are only 26 letters. so we can just use an array 
            // to stroe the index of the last time where the letter shows in the string.
            int[] last = new int[26];
            for (int i = 0; i < S.Length; i++)
            {
                last[S[i] - 'a'] = i;
            }

            IList<int> result = new List<int>();

            int start = 0;
            int end = 0;
            for (int i = 0; i < S.Length; i++)
            {
                // If the index of this letter's last appearance 
                // is greater than the end, it means if we cut the string here, 
                // the letter will show up again in the next part, so we need to 
                // extend the bundary of the substring
                end = Math.Max(end, last[S[i] - 'a']);

                // If the current index equals the maximum end,
                // that means all the letters before are in the same partition.
                if (i == end)
                {
                    result.Add(end - start + 1);
                    start = end + 1;
                }
            }
            return result;
        }

        [TestMethod]
        public void PartitionLabelsTest()
        {
            string S = "ababcbacadefegdehijhklij";

            var result = PartitionLabels(S);

            foreach(var n in result)
            {
                Console.WriteLine(n);
            }

        }
    }
}
