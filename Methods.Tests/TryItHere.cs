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

            int InputTarget = 3;
            int InputNumbers = 3;
            int[] InputArray = new int[] { 1, 4, 6, 8 };

            int[] result = ClosestNumbers.closestNumbers(InputTarget, InputNumbers, InputArray);
            foreach (var n in result)
            {
                Console.WriteLine(n);
            }
        }
    }
}
