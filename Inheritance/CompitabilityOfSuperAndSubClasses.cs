/*
 
 
 */
using System;
namespace Inheritance
    {
    class CompitabilityOfSuperAndSubClasses
        {
        public static void Main()
            {
            Person p1 = new Person();
            Person p2 = new Student();
            Person p3 = new GraduateStudent();

            Student s1 = new Student();
            Student s2 = new GraduateStudent();
           // Student s3 = new Person();//Shob Person Student na
            

            GraduateStudent g1 = new GraduateStudent();
            //GraduateStudent g2 = new Student();// shob Student Graduate Student na
            //GraduateStudent g3 = new Person();// shob Person Graduate Student na

            /// opoer hahini ta onkta int a = 5.6 er motoi
            // akhon jodi int a = 5.6 valid korte hoy taile amra obossoi type cast kori
            // that is int a = (int)5.6; // primative data type e direct type cast hoy
            // taile akhon amra object er o type cast korbo

            /*
            reference data type k sorasori primitive data type er moto type cast kora jay na 
            Student ss2 = (Student)new Person();//Shob Person Student na
            Console.WriteLine(ss2.name); 
            */

            Person p4 = new Student();
            Student s4 = (Student)p4;
            Console.WriteLine(s4.name);


            /*
            Person pp2 = new Student();
            Student ss2 = pp2 as Student;//Shob Person Student na
            Console.WriteLine(ss2.name);
            */
            }
        }
    class Person
        {
        public string name = "Jitu";
        public int age = 24;
        public string address = "Dhaka";

        }
    class Student:Person
        {
        public int roll = 28;
        public string institution = "PSTU";
        }
    class GraduateStudent:Student
        {
        public string gratuationDate = "Onischit";
        }

    }
