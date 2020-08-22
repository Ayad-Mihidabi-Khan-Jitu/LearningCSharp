using System;

namespace Practice
    {
    class Program
        {
         int n=34;
        static void Main(string[] args)
            {
            int n = 10;
            int m = n;
            Console.WriteLine("n = "+n+" "+ "m = " + m);   
            n = 90;
            Console.WriteLine("n = " + n + " " + "m = " + m);
            /*
            Program p1 = new Program();//
            Program p2 = p1;//
            p1.n = 12;
            Console.WriteLine("p1 = " + p1.n + " " + "p2 = " + p2.n); //
            p2.n = 90;
            Console.WriteLine("p1 = " + p1.n + " " + "p2 = " + p2.n); //
       */
            int []  nn = new int[] {234};
            //int [] mm = nn;
            int[] mm = new int[1] {1};
            //mm = nn;
            Console.WriteLine("nn[0] = " + nn[0] + " " + "mm = " + mm[0]); //1 1
            nn[0] = 13131;
            Console.WriteLine("nn[0] = " + nn[0] + " " + "mm = " + mm[0]);//234 1
            
            }
        }
    }