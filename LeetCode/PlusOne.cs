using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class PlusOne
    {
        public static int[] PluOne(int[] digits)
            {
            int siOfdig = digits.Length,sum=0,car=1;
            for (int i = siOfdig - 1; i >= 0; i--)
                {
                sum = digits[i] + car; ///1, 9, 9 -> 2  0  0         9  9 -> 1 0 0                 1  1  9 -> 1  2  0
                if (sum == 10)
                    {
                    digits[i] = 0;
                    car = 1;
                    }
                else 
                    {
                    digits[i] = digits[i] + 1;
                    car = 0;
                    break;
                    }          
                }

            if (car == 1)
                {
                int[] git = new int[siOfdig + 1];
                git[0] = 1;
                Array.Copy(digits,0, git,1, siOfdig);
                return git;
                }
            else return digits;

            }
        static void Main(string[] args)
        {
            int[] o = new int[] { 1, 1, 1 } ; // 1 2 0
           // PluOne(o);
            foreach (int i in PluOne(o))
                {
                Console.WriteLine(i);
                }



        }
    }
}
