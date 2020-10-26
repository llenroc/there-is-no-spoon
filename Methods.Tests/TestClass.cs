using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Methods.Tests
{
    [TestClass]

    public class TestClass

    {

        [AssemblyInitialize]

        public static void AssemblyInit(TestContext context)

        {

            Console.WriteLine("AssemblyInit " + context.TestName);

        }



        [ClassInitialize]

        public static void ClassInit(TestContext context)

        {

            Console.WriteLine("ClassInit " + context.TestName);

        }



        [TestInitialize]

        public void Initialize()

        {

            Console.WriteLine("TestMethodInit");

        }

        [TestMethod]

        public void MethodTest1()

        {

            Console.WriteLine("Executing Test...");

        }

        [TestMethod]

        public void MethodTest2()

        {

            Console.WriteLine("Executing Test2...");

        }



    }
}
