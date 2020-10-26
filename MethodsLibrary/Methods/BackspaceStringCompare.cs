namespace MethodsLibrary.Methods
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BackspaceStringCompare
    {
        public bool BackspaceCompare(string S, string T)
        {
            int si = S.Length - 1;
            int ti = T.Length - 1;
            int skipS = 0;
            int skipT = 0;

            while (si >= 0 || ti >= 0)
            {
                while (si >= 0)
                {
                    if (S[si] == '#')
                    {
                        skipS++;
                        si--;
                    }
                    else if (skipS > 0)
                    {
                        skipS--;
                        si--;
                    }
                    else
                    {
                        break;
                    }
                }
                while (ti >= 0)
                {
                    if (T[ti] == '#')
                    {
                        skipT++;
                        ti--;
                    }
                    else if (skipT > 0)
                    {
                        skipT--;
                        ti--;
                    }
                    else
                    {
                        break;
                    }
                }
                if (si >= 0 && ti >= 0)
                {
                    if (S[si] != T[ti])
                    {
                        return false;
                    }
                }
                else
                {
                    if (si >= 0 || ti >= 0)
                    {
                        return false;
                    }
                }
                si--;
                ti--;
            }
            return true;
        }

        [TestMethod]
        public void BackspaceCompareTest()
        {
            //Input: S = "ab#c", T = "ad#c"
            //Output: true
            string s1 = "ab#c";
            string t1 = "ad#c";
            System.Console.WriteLine( BackspaceCompare(s1,t1));

            //Input: S = "ab##", T = "c#d#"
            //Output: true
            string s2 = "ab##";
            string t2 = "c#d#";
            System.Console.WriteLine(BackspaceCompare(s2, t2));

            //Input: S = "a##c", T = "#a#c"
            //Output: true
            string s3 = "a##c";
            string t3 = "#a#c";
            System.Console.WriteLine(BackspaceCompare(s3, t3));

            //Input: S = "a#c", T = "b"
            //Output: false
            string s4 = "a##c";
            string t4 = "b";
            System.Console.WriteLine(BackspaceCompare(s4, t4));

        }
    }
}
