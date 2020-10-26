namespace MethodsLibrary.Methods
{

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class LargerNumberComparator : IComparer<string>
    {
        public int Compare(string a, string b)
        {
            string order1 = a + b;
            string order2 = b + a;
            return order2.CompareTo(order1);
        }
    }

    [TestClass]
    public class LargestNumberClass
    {
        public string LargestNumber(int[] nums)
        {
            string[] sNums = new string[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                sNums[i] = nums[i].ToString();
            }

            //Array.Sort(sNums, new LargerNumberComparator());

            Array.Sort(nums, delegate (int i, int j)
            {
                if (i == j) return 0;
                return -(i.ToString() + j.ToString()).CompareTo(j.ToString() + i.ToString());
            });

            // If, after being sorted, the largest number is `0`, the entire number
            // is zero.
            if (sNums[0]== "0")
            {
                return "0";
            }

            StringBuilder result = new StringBuilder();
            foreach (var s in sNums)
            {
                result.Append(s);
            }

            return result.ToString();
        }

        [TestMethod]
        public void LargestNumberTest()
        {
            string[] s = new string[] { "3","30","34","5","9"};

            Array.Sort(s, new LargerNumberComparator());
            
            foreach(var a in s)
            {
                Console.Write(a+ " ");
            }

        }

        public string LargestNumberUsingList(int[] nums)
        {
            List<string> list = new List<string>(nums.Length);
            int sum = 0;
            foreach (int i in nums)
            {
                list.Add(i.ToString());
                sum += i;
            }
            if (sum == 0)
            {
                return "0";
            }
            list.Sort((x, y) =>
            {
                return (x + y).CompareTo(y + x);
            });
            StringBuilder sb = new StringBuilder();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                sb.Append(list[i]);
            }
            string res = sb.ToString();
            return res;
        }
    }
}


