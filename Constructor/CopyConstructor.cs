/*
 ata special kichui na just amon akta constructor jeta parameter hisebe object reference ney that's why oi object ta hububu copy hoye jay.
*/

using System;
namespace Constructor
{
    class CopyConstructor
    {
        string name;

        CopyConstructor(string n)
            {
            Console.WriteLine("First constructor taking string as parameter");
            this.name = n;
            }

        CopyConstructor(CopyConstructor c)
            {
            Console.WriteLine("Second constructor taking The Class as parameter");
            this.name = c.name;
            }

        void DisplayName()
            {
            Console.WriteLine("Name : " + this.name);
            }


        public static void Main()
        {
            Console.WriteLine("Entering into the main method");
            CopyConstructor c1 = new CopyConstructor("Jitu");
            c1.DisplayName();

            CopyConstructor c2 = new CopyConstructor("Eshita");
            c2.DisplayName();

            CopyConstructor c3 = new CopyConstructor(c1);
            c3.DisplayName();

            CopyConstructor c4 = new CopyConstructor(c2);
            c4.DisplayName();
            }
    }
}
