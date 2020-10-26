


namespace MethodsLibrary.Methods
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ReverseString
    {
        public void ReverseStringg(char[] s)
        {
            if (s == null || s.Length == 0)
            {
                return;
            }
            int t = 0;
            int w = s.Length - 1;
            while (t < w)
            {
                char temp = s[t];
                s[t] = s[w];
                s[w] = temp;
                t++;
                w--;
            }
        }

        [TestMethod]
        public void ReverseStringTest()
        {
            char[] c1 = new char[] { };
            char[] c2 = new char[] { '1', '2' };
            char[] c3 = new char[] { '1', '2', '3' };
            char[] c4 = new char[] { '1', '2', '3', '4' };

            ReverseStringg(c3);

            foreach(var c in c3)
            {
                System.Console.Write(c+" ");
            }
            System.Console.WriteLine();
        }
    }
}
