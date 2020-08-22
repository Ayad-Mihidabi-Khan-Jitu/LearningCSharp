using System;
namespace Inheritance
    {
    class Inheritance
        {
        static void Main(string[] args)
            {
            Console.WriteLine("Inheritance");
            GovtTeacher t1 = new GovtTeacher();
            t1.personName();
            t1.salaryInstitution();
            t1.eidBonus();
            t1.penofins();
            }
        }
    class Person
        {
        public string name = "Jitu";
        public void personName()
            {
            Console.WriteLine("Name of the person : " + name);
            }
        }
    class Teacher : Person
        {
        public int salary = 100000;
        public string institution = "PSTU";
        public void salaryInstitution() {
        Console.WriteLine("Salary : "+salary);
        Console.WriteLine("Institution : "+ institution);

        }
    }
    class PrivateTeacher:Teacher
        {
        public int eeidi=50000;
        public void eidBonus()
            {
            Console.WriteLine("Eid bonus "+eeidi);
            }
        }
    class GovtTeacher:PrivateTeacher
        {
        public int pension=3000000;
        public void penofins()
            {
            Console.WriteLine("Pension : "+ pension);
            }
        }
 
    }
