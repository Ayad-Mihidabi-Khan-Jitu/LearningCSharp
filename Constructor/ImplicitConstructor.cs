using System;

namespace Constructor
{
    public class ImplecitConstructor
    {
        string name;
        int battarybackup;
        bool controllable;
        string feature;
        
        /*
        ImplecitConstructor(){
            string name;
            int battarybackup;
            bool controllable;
            string feature;
            }
        */

        
        ImplecitConstructor(string s, string f, bool t, int n)
            {
             string name = s;
             int battarybackup = n;
             bool controllable = t;
             string feature = f;
            }
        
        public static void Main(string[] args)
        {
            //ImplecitConstructor robot = new ImplecitConstructor();
            //Constructor.ImplecitConstructor tom = new Constructor.ImplecitConstructor(); //valid
            // ImplecitConstructor tom = new Constructor.ImplecitConstructor(); //also valid
            /*
            Console.WriteLine("This is "+robot.name);
            Console.WriteLine(robot.feature);
            Console.WriteLine("This is kotha shone "+robot.controllable);
            Console.WriteLine("Battary backup "+robot.battarybackup+"hours");
            */

            /*
            robot.name = "Tom";
            robot.feature = "He takes care of Jerry";
            robot.controllable = true;
            robot.battarybackup = 12;
            
            Console.WriteLine("This is "+robot.name);
            Console.WriteLine(robot.feature);
            Console.WriteLine("This is kotha shone "+robot.controllable);
            Console.WriteLine("Battary backup "+robot.battarybackup+"hours");
*/

            ImplecitConstructor robot = new ImplecitConstructor("TOm", "He takes care of Jerry", true,12);
            Console.WriteLine("This is "+robot.name);
            Console.WriteLine(robot.feature);
            Console.WriteLine("This is kotha shone "+robot.controllable);
            Console.WriteLine("Battary backup "+robot.battarybackup+"hours");

            }

    }

}
