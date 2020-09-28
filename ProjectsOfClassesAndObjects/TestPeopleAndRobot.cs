using System;
using System.Collections.Generic;
using System.Text;

/* 
    default access modifiers
    class                      instance variable                        methods
    -------------------------------------------------------------
    internal                         private                                     private
 */

namespace ProjectsOfClassesAndObjects
{
    class TestPeopleAndRobot
    {
        public static void Main()
        {
            /*
            //how to create an object;
            // Syntex 
            // Class_Name     object_name      =     new Class(); 
            People peo1 = new People();
            Robot robo1 = new Robot();

            People peo2 = new People();
            Robot robo2 = new Robot();

            // how to assign a definite properity to an object
            //obname.insvariable = kisu akta;
            peo1.speakingToSomeone();
            peo1.name = "Jitu";
            peo1.age = 23;
            peo1.isConservative = true;
            //peo1.myrobot = robo1;
            ////obname.function();
            //peo1.speakingToSomeone();

            robo1.name = "Tom";
            robo1.ICNum = 12;
            robo1.speciallity = "Copy Everything";

            //Console.WriteLine("My Robot name is " + peo1.myrobot.name+" Introduce with him");
            robo1.selfIntrodution();

            peo2.name = "Joti";
            peo2.age = 23;
            peo2.isConservative = false;
            //peo2.myrobot = robo2;
            peo2.speakingToSomeone();

            robo2.name = "Jerry";
            robo2.ICNum = 9;
            robo2.speciallity = "Eat Everything";

            //Console.WriteLine("My Robot name is " + peo2.myrobot.name+" Introduce with him");
            robo2.selfIntrodution();
            */


         
            //Robot(name,speciallity, IC)
            Robot r1 = new Robot("Tom", "Can Copy", 12);
            Robot r2 = new Robot("Jerry", "Eat evarything", 5);
     
            //People(name,age,conser,robot)
            People p1 = new People("Jitu",24,true,r1);
            People p2 = new People("Eshita", 22, false, r2);

            p1.speakingToSomeone();
            Console.WriteLine("Meet with my robot");
            r1.selfIntrodution();

            p2.speakingToSomeone();
            Console.WriteLine("Meet with my robot");
            r2.selfIntrodution();
            


        }
    }
}
