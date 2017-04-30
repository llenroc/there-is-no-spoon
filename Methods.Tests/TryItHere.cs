using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MethodsLibrary.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Methods.Tests.Objects;
using MethodsLibrary.Methods;

namespace Methods.Tests
{
    [TestClass]
    public class TryItHere
    {

        [TestMethod]
        public void tryItHere()
        {

            IList list1 = new List<IList<int>>
            {
                new List<int>
                {
                    -1,
                    0,
                    1
                },
                new List<int>
                {
                    -1,
                    -1,
                    2
                }
            };

            IList list2 = new List<IList<int>>
            {
                new List<int>
                {
                    -1,
                    0,
                    1
                },
                new List<int>
                {
                    -1,
                    -1,
                    2
                }
            };

            int i = 0;
            while (list1.Count == list2.Count && i < list1.Count && i < list2.Count)
            {

                
                CollectionAssert.AreEqual((List<int>)list1[i], (List<int>)list2[i], "result sets are not equal");
                i++;
            }
            
        }
    }
}
