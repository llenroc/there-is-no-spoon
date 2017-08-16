using System;
using System.Collections.Generic;
using MethodsLibrary.Methods;
using MethodsLibrary.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
                new Interval(1, 3),
                new Interval(2, 6),
                new Interval(8, 10),
                new Interval(15, 18)
            };
            outputIntervals = new List<Interval>
            {
                new Interval(1, 6),
                new Interval(8, 10),
                new Interval(15, 18)
            };
        }

        [TestMethod]
        public void mergeIntervalsTest()
        {
            IList<Interval> result = MergeIntervals.Merge(inputIntervals);

            Console.WriteLine("Actual result: ");
            foreach (Interval interval in result)
            {
                Console.WriteLine("Start: " + interval.start + ", " + "End: " + interval.end);
            }
            Console.WriteLine("Expected result: ");
            foreach (Interval interval in outputIntervals)
            {
                Console.WriteLine("Start: " + interval.start + ", " + "End: " + interval.end);
            }
        }
    }
}