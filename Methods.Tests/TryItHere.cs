using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MethodsLibrary.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Methods.Tests.Objects;
using MethodsLibrary.Methods;
using System.Text.RegularExpressions;

namespace Methods.Tests
{
    [TestClass]
    public class TryItHere
    {

        [TestMethod]
        public void tryItHere()
        {

            string ss = "   a   b ";
            ss = ss.Trim();
            string[] strings = Regex.Split(ss, @"\W+");

            foreach(string s in strings)
            {
                Console.Write(s + ", ");
            }
        }
    }
}
