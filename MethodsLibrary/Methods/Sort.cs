


namespace MethodsLibrary.Methods
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Sort
    {

        #region Bubble Sort
        public void BubbleSort(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
        }
        #endregion

        #region Selection Sort
        public void SelectionSort(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = nums[i];
                nums[i] = nums[minIndex];
                nums[minIndex] = temp;
            }
        }
        #endregion

        #region Insert Sort
        public void InsertSort(int[] nums)
        {
            for (int i=1; i<nums.Length; i++)
            {
                int temp = nums[i];

                int j = i;
                while (j>0 && temp < nums[j-1])
                {
                    nums[j] = nums[j - 1];

                    j--;
                }

                //if (j != i)
                //{
                    nums[j] = temp;
                //}
            }
        }
        #endregion




        [TestMethod]
        public void SortingTest()
        {
            int[] a = new int[] { 5, 2, 1, 4, 8, 9, 6, 3 };
            int[] b = new int[] { 2, 1 };
            int[] c = new int[] { 1 };
            int[] d = new int[] { 2, 0, 2, 1, 1, 0 };


            Console.WriteLine("Original Array:");
            PrintArray(c);

            //BubbleSort(a);
            //SelectionSort(d);
            InsertSort(c);

            Console.WriteLine("Sorted Array:");
            PrintArray(c);
        }

        public void PrintArray(int[] nums)
        {
            foreach (var n in nums)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }



}
