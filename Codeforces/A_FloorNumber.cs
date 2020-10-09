using System;
using System.Collections.Generic;
using System.Text;

namespace Codeforces
    {
    class A_FloorNumber
        {
        static void Main()
            {
            int t = Convert.ToInt32(Console.ReadLine());
            while (t!=0)
                {t--;
                    int [] nx = Array.ConvertAll(Console.ReadLine().Split(" "),item=>Convert.ToInt32(item));
                    double n = nx[0], x=nx[1]; int bou = 1; 
                    n = n - 2;
                    while (n > 0)
                        {
                        n = n - x;
                        bou++;
                        }
                    Console.WriteLine(bou);
                }
         }
     }
 }
