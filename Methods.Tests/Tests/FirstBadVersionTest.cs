using System;
using MethodsLibrary.Methods;
using MethodsLibrary.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods.Tests.Tests
{
    [TestClass]
    public class FirstBadVersionTest
    {
        [TestMethod]
        public void firstBadVersion()
        {
            VersionControl.BadVersion = 1702766719;
            int versions = 2126753390;
            //VersionControl.BadVersion = 4;
            //int versions = 10;

            Console.WriteLine("First Bad Version: " + VersionControl.BadVersion);
            Console.WriteLine("Number of versions: " + versions);
            Console.WriteLine("Actual result: " + FirstBadVersion.firstBadVersion(versions));

            Assert.AreEqual(FirstBadVersion.firstBadVersion(versions), VersionControl.BadVersion);
        }
    }
}