///A Class is a user defined datatype
using System;
namespace ClassesStructuresAndObjects
    {
    class Classes
        {
        ///Instance Variables
        public int varible1;
        public string welcomeMsg;
        
        ///Constructor
        public Classes()
            {
            this.varible1 = 256;
            this.welcomeMsg = "This is a Variable";
            }

        ///Methods
        public void Display()
            {
            Console.WriteLine(this.welcomeMsg);
            Console.WriteLine(this.varible1);
            }

        }
    }
