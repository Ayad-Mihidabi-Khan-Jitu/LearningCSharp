/*
 
hoy ni ata wrong khaisi

*/

using System;
using System.Collections.Generic;
using System.Text;
namespace LeetCode
    {
    class FindNUniqueIntegersSumUptoZero
        {
        public static int[] SumZero(int n)
            {
            int[] smz = new int[n];
            for(int i = 0; i < n/2; i++)
                { 
                smz[i] = i + 1;
                smz[(n - 1) - i] = -(i + 1);
                }
            return smz;

            }
        static void Main(string[] args)
            {
            int[] n=SumZero(3);
            foreach(int h in n)
                Console.WriteLine(h);

            }
            }
    }
