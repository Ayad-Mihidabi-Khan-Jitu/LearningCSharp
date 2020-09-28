using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace LeetCode
    {
    class MatrixDiagonalSum
        {
        public static int DiagonalSum(int[][] mat)
            {
           /*
           j   0  1  2  3   ar[i][(size-1)-i] ar[0][2]
      i   0   1  2  3  4                                  ar[1][1]
          1   4  5  6  5                                  ar[2][0]
          2   6  7  8  9                          ar[s/2][s/2]
          3   4  5  6  7        
          */

            int si = mat.Length;
            int bou = 0;
            for (int k = 0; k < si; k++)
                {
                bou = bou+ mat[k] [k] + mat[k] [si - 1 - k];
                }
            if (si % 2 != 0)
                return bou - mat[si / 2] [ si / 2];
            else
                return bou;

            }
        static void Main(string[] args)
            {
            int[][] mat = new int[][]{new int[] {1,2,3 }, new int []{1,2,3 }, new int []{ 1,1,2} };
            
            Console.WriteLine(DiagonalSum(mat));
                 
            }
        }
    }
