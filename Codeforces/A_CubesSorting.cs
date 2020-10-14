using System;
using System.Linq;
using System.Collections.Generic;

namespace Codeforces
    {
    class A_CubesSorting
        {
        static void Main(string[] args)
            {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int z = t; z > 0; z--)
                {
                int n = Convert.ToInt32(Console.ReadLine());
                int c=1;

                ///Space saperated array input taking
                int[] a = Array.ConvertAll(Console.ReadLine().Split(" "), (item) => Convert.ToInt32(item));
                //char[] a = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToChar(item));

                for (int i = 0; i < n - 1; i++) if (a[i] <= a[i + 1]) { c = 0; break; } 
                if (c!=0) Console.WriteLine("NO"); 
                else Console.WriteLine("YES");
                }
            }

    /*
     ///TLE khaisi
    static void exchange ( List<int> l, int a, int b) 
            {
            int temp = l[a];
            l[a] = l[b];
            l[b] = temp;
            }
        static void Main(string[] args)
            {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int z = t;z>0;z--) {
                int n = Convert.ToInt32(Console.ReadLine());
                int maxsofn = ((n * (n - 1)) / 2) - 1;
                //List<int> li = new List<int>(n);

                int[] v = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));
                List<int> li = new List<int>(v);

                /*
                /// ata space saperated input nei na  only enter kore
                for (int g = 1; g <= n; g++)
                    {
                    
                    int v = Convert.ToInt32(Console.ReadLine());
                    li.Add(v);
                    
                    }
                */
                /*
                //Console.WriteLine(li.Count);
                int bou = 0;
                for (int i = 0; i < li.Count; i++)
                    {
                    for (int j = i + 1; j < li.Count; j++)
                        {
                        if (li[i] > li[j])
                            {
                            bou++;
                            exchange(li, i, j);
                            }
                        }
                    }
                if (bou > maxsofn) Console.WriteLine("NO");
                else Console.WriteLine("YES");            
                } 
    */

            
        }
    }
