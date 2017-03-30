using System;
using System.Collections.Generic;
using System.Linq;
using MethodsLibrary.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Methods.Tests.Objects;

namespace Methods.Tests
{
    [TestClass]
    public class TryItHere
    {

        [TestMethod]
        public void tryItHere()
        {
            string s = "abcdefg";
            for (int i=0; i<s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }

        }
    }
}
