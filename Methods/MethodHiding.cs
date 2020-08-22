/*
 Method overriding ar method hiding aki jinish
 taile tuita ala korar ki dorkar??
 Difference dekhle e bojha jabe:

 Overriding                                                                                                                       hiding
 ---------------------------------------------------------------------------------------------------------------------
 i) syntex:     Super Class                                     | i) syntex:            Super Class
     virtual functionName(){code}                     |     functionName(){code}           
                        Sub Class                                         |                                 Sub Class
    override functionName(){code}                   |     new functionName(){code} or functionName(){code} 
 ii) Main difference : Super class er instance jodi Sub class er instance k refer kore tahole 
                                        super class er instance dara probeshkrito overriden method betito method 
                                        direct Super Class er method k call kore. 
 */

///ami kichu akta
using System;
namespace Methods
    {
    class MethodHiding
        {
        public static void Main()
            {
            Daughter meye = new Daughter();
            //meye.subMethod();
            Father baba = meye;
            baba.supMethod();
            baba.VsupMethod();
            }
        }
    class Father
        {
        string f_name = "I am father";
        public void supMethod()
            {
            Console.WriteLine("This is in Super Class : "+f_name);
            }
        public virtual void VsupMethod()
            {
            Console.WriteLine("This is in Super Class : (defined as virtual) " + f_name);
            }
        }
    class Daughter:Father
        {
        string d_name = "I am daughter";
        //public void supMethod()
        public new void supMethod()
            {
            Console.WriteLine("This is in Super Class : " + d_name);
            }
        public override void VsupMethod()
            {
            Console.WriteLine("This is in Super Class : (defined as overriden) " + d_name);
            }

        }
    }
