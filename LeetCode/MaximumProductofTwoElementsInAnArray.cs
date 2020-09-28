using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
    {
    class MaximumProductofTwoElementsInAnArray
        {
        public static int MaxProduct(int[] nums)
            {
            List<int> nm = new List<int>(nums);
            nm.Sort();
            //nm.Reverse();
            return (nm[nm.Count - 1] - 1) * (nm[nm.Count - 2] - 1);
            }
        static void Main(string[] args)
           {
            int[] nums = { 1, 2, 3, 4 };
            Console.WriteLine(MaxProduct(nums));
           }
        }
    }