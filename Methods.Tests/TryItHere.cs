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
            Assert.Fail("La Ji!");
            Assert.AreEqual(1, 1, "test 1 failed");
            Assert.AreEqual(1, 4, "test 3 failed");
            Assert.Inconclusive("test 2 failed");

        }
    }
}
