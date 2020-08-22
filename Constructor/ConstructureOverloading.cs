using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Constructor
{
    class ConstructureOverloading
    {
        int x;
        string n;
        bool t;
       ConstructureOverloading()
        {
           x = 100;
            n = "Jit";
            t = false;
        }
        ConstructureOverloading(int x,string n)
        {
            this.x = x;
            this.n = n;
            this.t = false;
        }
        ConstructureOverloading(int x,string n,bool t)
        {
            this.x = x;
            this.n = n;
            this.t = t;
        }
        public static void Main()
        {
            ConstructureOverloading c1 = new ConstructureOverloading();
            Console.WriteLine(c1.x + " " + c1.n+" "+c1.t);
            c1 = new ConstructureOverloading(200,"jitu");
            Console.WriteLine(c1.x + " " + c1.n + " " + c1.t);
            c1 = new ConstructureOverloading(300, "jitu",true);
            Console.WriteLine(c1.x + " " + c1.n + " " + c1.t);
        }

    }
}
