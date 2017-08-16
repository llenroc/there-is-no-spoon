using System;
using System.Collections.Generic;
using MethodsLibrary.Objects;

namespace MethodsLibrary.Methods
{
    public class MergeIntervals
    {
        /// <summary>
        /// Given a collection of intervals, merge all overlapping intervals.
        /// For example,
        /// Given[1, 3],[2, 6],[8, 10],[15, 18],
        /// return [1,6],[8,10],[15,18].
        /// The key point is to make sure the intervals are sorted
        /// </summary>
        /// <param name="intervals"> A list of intervals </param>
        /// <returns> A list of merged intervals </returns>
        public static IList<Interval> Merge(IList<Interval> intervals)
        {
            IList<Interval> result = new List<Interval>();
            if (intervals.Count <= 1)
            {
                return intervals;
            }

            int length = intervals.Count;
            int[] starts = new int[length];
            int[] ends = new int[length];

            for (int i = 0; i < length; i++)
            {
                starts[i] = intervals[i].start;
                ends[i] = intervals[i].end;
            }

            Array.Sort(starts);
            Array.Sort(ends);

            result.Add(new Interval(starts[0], ends[0]));
            for (int i = 1; i < length; i++)
            {
                if (starts[i] <= result[result.Count - 1].end)
                {
                    result[result.Count - 1].end = ends[i];
                }
                else
                {
                    result.Add(new Interval(starts[i], ends[i]));
                }
            }

            return result;
        }

        // Not mine but better performance to learn.
        // The key point is to make sure the intervals are sorted
        public IList<Interval> MergeRevised(IList<Interval> intervals)
        {
            if ((intervals == null) || (intervals.Count == 0))
            {
                return intervals;
            }
            List<Interval> myinterval = new List<Interval>(intervals);
            myinterval.Sort((first, second) => { return first.start - second.start; });
            List<Interval> result = new List<Interval>();
            Interval current = myinterval[0];
            for (int i = 1; i < myinterval.Count; i++)
            {
                if (current.end >= myinterval[i].start)
                {
                    current.end = Math.Max(current.end, myinterval[i].end);
                }
                else
                {
                    result.Add(current);
                    current = myinterval[i];
                }
            }
            result.Add(current);
            return result;
        }
    }
}