namespace Methods.Tests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PlayGround
    {
        [TestMethod]
        public void PlayGroundTest()
        {

            string S = "BAONXXOLL";
            string S2 = "BAOOLLNNOLOLGBAXA";
            string S3 = "QWEOAIDVOS";


            Console.WriteLine(solution(S3));
        }

        public int solution(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (S == null || S.Length == 0)
            {
                return 0;
            }
            int num = 0;
            var dict = new Dictionary<char, int>();

            foreach (var c in S)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }

            string target = "BALLOON";

            var balloon = new Dictionary<char, int>();
            foreach (var c in target)
            {
                if (balloon.ContainsKey(c))
                {
                    balloon[c]++;
                }
                else
                {
                    balloon.Add(c, 1);
                }
            }
            bool hasWord = true;

            while (hasWord)
            {
                foreach (var l in balloon)
                {
                    if (! dict.ContainsKey(l.Key) || dict[l.Key] < l.Value)
                    {
                        hasWord = false;
                        break;
                    }
                    else
                    {
                        dict[l.Key] = dict[l.Key] - l.Value;
                    }
                }

                if (hasWord) num++; 
            }

            return num;
        }
    }
}
