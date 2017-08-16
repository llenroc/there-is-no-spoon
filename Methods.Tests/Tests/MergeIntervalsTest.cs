using System;
using System.Collections.Generic;
using Methods.Tests.Objects;
using MethodsLibrary.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MethodsLibrary.Objects;

namespace Methods.Tests.Tests
{
    [TestClass]
    public class MergeIntervalsTest
    {
        private IList<Interval> inputIntervals;
        private IList<Interval> outputIntervals;


        [TestInitialize]
        public void Initialization()
        {
            inputIntervals = new List<Interval>
            {
                new Interval(1,3),
                new Interval(2,6),
                new Interval(8,10),
                new Interval(15,18)
            };
            outputIntervals = new List<Interval>
            {
                new Interval(1,6),
                new Interval(8,10),
                new Interval(15,18)
            };

        }

        [TestMethod]
        public void mergeIntervalsTest()
        {
            IList<Interval> result = MergeIntervals.Merge(inputIntervals);

            foreach(Interval interval in result)
            {
                Console.WriteLine("Start: " + interval.start + ", " + "End: " + interval.end);
            }

            foreach (Interval interval in outputIntervals)
            {
                Console.WriteLine("Start: " + interval.start + ", " + "End: " + interval.end);
            }

        }
    }
}
