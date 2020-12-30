///C# does not support macros in preprocessors like C,C++
///So amra function create kore pari
//ja ja dekhbo: Console.WriteLine() -> WriteLine()
//                          Console.WriteLine() -> cout()
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace MacrosAndPreProcessors
    {
    static class Program
        {
        public static void cout(this string str, params object[] args)
            {
            Console.WriteLine(str, args);
            }
        static void Main(string[] args)
            {
            //1. Console.WriteLine() -> WriteLine()
            WriteLine("This is WriteLine() ");

            //2. Console.WriteLine() -> cout()
            cout("This is cout({0})", 1);
            ReadLine();
            }
        }
    }
