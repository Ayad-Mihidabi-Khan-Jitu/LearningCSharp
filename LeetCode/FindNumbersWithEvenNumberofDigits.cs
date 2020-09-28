using System;

namespace LeetCode
    {
     class FindNumbersWithEvenNumberofDigits
        {
        public static int FindNumbers(int[] nums) //nums = 11,2,4444
            {
            int bou = 0;
            for (int i = 0; i < nums.Length; i++)
                {
               
                int d = (int)Math.Log10(nums[i])+1;
                if (d % 2 == 0)  bou++;
                Console.WriteLine(d);
                }
            return bou;
            }
        static void Main(string[] args)
            {
            Console.WriteLine("Hello World!");
            int[] nums = { 1, 22, 4 };
            Console.WriteLine(FindNumbers(nums)) ;
            }
        }
    }
