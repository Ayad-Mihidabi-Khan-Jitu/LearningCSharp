/*
 Class er nam shunei bujhteso ghotonata ki!!
 #Kon class er kon class er object create korete parbe seta :
 1. Valid object reference creation : parent class er object reference tar child class er object dara create kora jabe 
 2. invalid object reference creation : child class er object reference tar parent class er object dara create kora jabe na
     * but ai invalid kaj ta o valid kora jay seta holo type cast er maddhome
     * just type cast korlei hobe na child class er object reference ta je parent er hobe tar object reference ta ai child class
        er hote hobe.
 #Dynamic method despatch : ai jinish ta onek ta method overload er dharonar moto.
    accha method overloading er ghotona ta boloto inbrief!!!
    overloaded method call korar por kon method ta call hobe seta depend korto kon parameter dia call kora holo
    that is call krito method er parameter er sathe je method er defination milto se mathod call hoto.
    thik method overloading er motoi dynamic vabe method choise korte pare but obossoi method overriden hote hobe
    abong tokhon e object er opor depend kore.   
*/
using System;
namespace Inheritance
    {
    class CompitabilityOfSuperAndSubClasses
        {
        public static void Main()
            {
            ///Parent class tar child class er memory point/refer korte pare
            Person p1 = new Person();
            Person p2 = new Student();
            Person p3 = new GraduateStudent();

            Student s1 = new Student();
            Student s2 = new GraduateStudent(); 
            //Student s3 = new Person(); //Shob Person Student na
            
            GraduateStudent g1 = new GraduateStudent();
            //GraduateStudent g2 = new Student();// shob Student Graduate Student na
            //GraduateStudent g3 = new Person();// shob Person Graduate Student na

            ///opoer hahini ta onkta int a = 5.6 er motoi
            // akhon jodi int a = 5.6; valid korte hoy taile amra obossoi type cast kori
            // that is int a = (int)5.6; // primative data type e direct type cast hoy
            // taile akhon amra object er o type cast korbo

            ///Child class directly tar parent class er memory point/refer korte pare na 
            //se jonno type cast korte hoy ar ha reference data type k sorasori primitive data type er moto type cast kora jay na 
            //Student s3 = new Person(); //direct wrong asbe Shob Person Student na tai that is implicitly compiler ata type cast korbe na 
            ///type cast korlam...1
            //Student s3 = (Student)new Person(); //No error but runtime e exception: Unable to cast object of type 'Inheritance.Person' to type 'Inheritance.Student'

            ///type cast korlam...2
            //Person p4= new Person();
            //Student s3 = (Student)p4; //No error but runtime e exception: Unable to cast object of type 'Inheritance.Person' to type 'Inheritance.Student'

            ///type cast korlam...3
            //Person p5 = new Person();
            //Student s4 = new Student();
            //s4 = (Student)p5; //No error but runtime e exception: Unable to cast object of type 'Inheritance.Person' to type 'Inheritance.Student'

            /// type cast korlam...4 and  parent class er object ta child class er memory k point kore thakbe
            //Person p6 = new Student();  // int i = 6; double d = i; 
 
            //Student s5 = (Student)p6;    // i = d; //Successful type cast
            //Console.WriteLine(p6.roll); //roll is not avaible in person
            //Console.WriteLine(s5.name); //

            /// type cast korlam...5 and  parent class er object ta child class er memory k point kore thakbe
            //Student s7 = new Student();
            //Person p8 = s7;
            //Console.WriteLine(p8.name);
            //Student s8 = (Student)p8; //Successful type cast
            //Console.WriteLine(s8.roll);
            /*
            Person pp2 = new Student();
            Student ss2 = pp2 as Student;//Shob Person Student na
            Console.WriteLine(ss2.name);
            */

            Person p9 = new Person();
            Person p10 = new Student();
            Person p11 = new GraduateStudent();
            GraduateStudent g3 = new GraduateStudent();
            Student s31 = new GraduateStudent();
            s31.Activity();
            //p9.Activity();//per
            //p10.Activity();//stu
            //p11.Activity();//gtu
            //g3.Activity();


            }
        }
    class Person
        {
        public string name = "Jitu";
        public int age = 24;
        public string address = "Dhaka";
        public virtual void Activity()
            {
            Console.WriteLine("Ami Person");
            } 
        }
    class Student:Person
        {
        public int roll = 28;
        public string institution = "PSTU";
        public override void Activity()
            {
            Console.WriteLine("Ami Student");
            }
        }
    class GraduateStudent:Student
        {
        public string gratuationDate = "Onischit";
        public override void Activity()
            {
            Console.WriteLine("Ami Graduate Student");
            }
        }


    }
