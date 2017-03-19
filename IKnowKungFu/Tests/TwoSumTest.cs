using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MethodsLibrary;

namespace IKnowKungFu
{
    [TestClass]
    public class TwoSumTest
    {

        public List<Inputs> TestData { set; get; }

        [TestInitialize]
        public void SetUp()
        {
            this.TestData.Add( new Inputs()
            {
                intArrayInput = new int[] { 2, 7, 11, 15 },
                intInput = 9
            });

            this.TestData.Add(new Inputs()
            {
                intArrayInput = new int[] { 3, 2, 4 },
                intInput = 6
            });

            this.TestData.Add(new Inputs()
            {
                intArrayInput = new int[] { 230, 863, 916, 585, 981, 404, 316, 785, 88, 12, 70, 435, 384, 778, 887, 755, 740, 337, 86, 92, 325, 422, 815, 650, 920, 125, 277, 336, 221, 847, 168, 23, 677, 61, 400, 136, 874, 363, 394, 199, 863, 997, 794, 587, 124, 321, 212, 957, 764, 173, 314, 422, 927, 783, 930, 282, 306, 506, 44, 926, 691, 568, 68, 730, 933, 737, 531, 180, 414, 751, 28, 546, 60, 371, 493, 370, 527, 387, 43, 541, 13, 457, 328, 227, 652, 365, 430, 803, 59, 858, 538, 427, 583, 368, 375, 173, 809, 896, 370, 789 },
                intInput = 542
            });
        }


        [TestMethod]
        public void twoSumTest()
        {
            Assert.AreEqual(TwoSum.twoSum(TestData[0].intArrayInput,TestData[0].intInput ), new int[] { 0, 1 });
            Assert.AreEqual(TwoSum.twoSum(TestData[1].intArrayInput, TestData[1].intInput), new int[] { 1, 2 });
            Assert.AreEqual(TwoSum.twoSum(TestData[2].intArrayInput, TestData[2].intInput), new int[] { 28, 45 });
            //int[] nums = { 2, 7, 11, 15 };
            //int target = 9;

            //int[] result = TwoSum(nums, target);

            //foreach (int i in result)
            //{
            //    Console.Write(i + ", ");
            //}
            //Console.WriteLine();

            //int[] nums1 = { 3, 2, 4 };
            //int target1 = 6;
            //int[] result1 = TwoSum(nums1, target1);
            //foreach (int i in result1)
            //{
            //    Console.Write(i + ", ");
            //}
            //Console.WriteLine();

            //int[] nums2 = { 230,863,916,585,981,404,316,785,88,12,70,435,384,778,887,755,740,337,86,92,325,422,815,650,920,125,277,336,221,847,168,23,677,61,400,136,874,363,394,199,863,997,794,587,124,321,212,957,764,173,314,422,927,783,930,282,306,506,44,926,691,568,68,730,933,737,531,180,414,751,28,546,60,371,493,370,527,387,43,541,13,457,328,227,652,365,430,803,59,858,538,427,583,368,375,173,809,896,370,789 };
            //int target2 = 542;
            //int[] result2 = TwoSum(nums2, target2);
            //foreach (int i in result2)
            //{
            //    Console.Write(i + ", ");
            //}
            //Console.WriteLine();
        }

        /*
        public int[] TwoSum(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return null;
            }
            int[] result = new int[2];
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    result[0] = dict[target - nums[i]];
                    result[1] = i;
                }
                else
                {
                    if (!dict.ContainsKey(nums[i]))
                        dict.Add(nums[i],i);
                }
            }
            return result;
        }
        */
    }

}
