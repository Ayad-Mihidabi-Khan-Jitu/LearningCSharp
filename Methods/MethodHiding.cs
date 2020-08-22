using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
    {
    class MethodHiding
        {
        public static void Main()
            {
            /*
            Father baba = new Father();
            baba.supMathod();

            Daughter meye = new Daughter();
            meye.supMathod();
            */
            Daughter d1 = new Daughter();
            Father f1 = d1;
            f1.supMathod();
            f1.VsupMathod();
            }

        }
    class Father
        {
        string f_name = "I am father";
        public void supMathod()
            {
            Console.WriteLine("This is Seper Class : " + f_name);
            }
        public virtual void VsupMathod()
            {
            Console.WriteLine("This is Seper Class : " + f_name);
            }

        }
    class Daughter:Father
        {
        string d_name = "I am daughter";
        public new void supMathod()
            {
            Console.WriteLine("This is Sub Class : " + d_name);
            }
        public override void VsupMathod()
            {
            Console.WriteLine("This is Seper Class : " + d_name);
            }

        }
    }
