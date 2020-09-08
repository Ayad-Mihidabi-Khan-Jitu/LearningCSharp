using System;

namespace Practice
    {
    class Class1
        {
        public static void Main()
            {
             People p1=null;
             //Console.WriteLine(p1.GetType());
             p1  = new People();
            Console.WriteLine(p1.GetType());
            Console.WriteLine(p1.t);
            int hu = p1.t;
            Console.WriteLine(hu.GetType());

            People p2 = p1;
            Console.WriteLine(p2.GetType());
            Console.WriteLine(p2.t);
            p1.t = 100;
            Console.WriteLine(p2.t);
            int f =Guava.h;
            Console.WriteLine(f);
            }
        }

    class People
        {
        public int t = 10;
        public int n;
        }
    static class Guava
        {
        static public int h = 10;
        }
    }
