using System;
namespace HackerEarth
    {
    class Program
        {
        public static int [] RightRotate(int [] x,int r)
            {
            if (r == 0) return x;
            int s = x.Length;
            ReverseArray(x, s-r, s-1);
            ReverseArray(x, 0,s- r-1);
            ReverseArray(x, 0, s-1);
            return x;
            }
        public static void ReverseArray(int [] arr,int start,int end)
            {
            while (start < end)
                {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;end--;
                }
                
            }


        static void Main(string[] args)
            {
            int t = Convert.ToInt32(Console.ReadLine());
            while (t!=0)
                {t--;
                 int[] karr = Array.ConvertAll(Console.ReadLine().Split(" "), item => Convert.ToInt32(item));
                 int k = karr[0],r= karr[1]% karr[0]; // in case r>k
                 int[] x = Array.ConvertAll(Console.ReadLine().Split(" "), item => Convert.ToInt32(item));

                /*///Acceped but TLE
              int[] x1 = new int[k];
              x1= RightRotate(x, r);
              foreach (int ux in x1)
                 {
                   Console.Write(ux + " ");
                  }Console.WriteLine();
              */

                /*///Acceped but TLE
                Array.Reverse(x, k - r, r);            ///1 2 3 4 5       1 2 3 5 4      3 2 1 5 4      4 5 1 2 3 
                Array.Reverse(x, 0, k - r);
                Array.Reverse(x, 0, k );
                foreach (int re in x)
                    {
                    Console.Write(re + " ");
                    }Console.WriteLine();
             */

                /* ///Wrong and Runtime Error
              for(int i = 0; i < r; i++)
                        {
                        x1[0] = x[k-1];
                        for (int j = 1 ; j <x.Length ; j++) ///1 2 3 4 5      5 1 2 3 4        4 5 1 2 3
                            {
                            x1[j] = x[j-1];
                            }
                        Array.Copy(x1, x,k);
                    }
              foreach(int re in x1)
                        {
                        Console.Write(re+" ");
                        }Console.WriteLine();
                */
                }
            }
        }
    }
