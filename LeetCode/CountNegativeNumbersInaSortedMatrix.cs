using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
    {
    class CountNegativeNumbersInaSortedMatrix
        {
        public static int CountNegatives(int[][] grid)
            {
            int si = grid.Length, bou = 0;
            Console.WriteLine(si);
            for (int i = 0; i < grid.Length; i++)
                {
                for (int j = 0; j < grid[i].Length; j++)
                    {
                    Console.WriteLine(i + " " + j);
                    if (grid[i][j] < 0)
                        {
                        bou++;
                        }
                    }
                }
            return bou;
            }
        static void Main(string[] args)
            {
            int[][] grid = new int[][] { new int[] { 1, 2, 3 }, new int[] { -2, -3, -4 } };
            CountNegatives(grid);
            }
        }
    }
