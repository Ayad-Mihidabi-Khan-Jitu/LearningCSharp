/*
  akta subclass method superclass er method k tokhon e override korbe jokhon subclass method ti super class er hubuhu thakbe
  overrided method ti subclass er akta sotontro method er moto kaj kore
  Difference Between Overload and Overriding : 
                    ----------------------------------------------------------------
                           aki class e er moddhe    |    subslass and super class er moddhe(obossoi vinno class era)
                   method load hoy by name    |    method defination replace hoy   
      method name ta same holei hoy     |    method name and parameter same hote hobe
 */
using System;
namespace Methods
    {
    class MethodOverriding
        {
        public static void Main()
            {
            Mother ma = new Mother();
            ma.supMethod();
            Console.WriteLine(ma.m_name);

            Son chele = new Son();
            chele.supMethod();
            Console.WriteLine(chele.m_name); 
            Console.WriteLine(chele.s_name); 
            }
        }

    ///this is super class
    class Mother
        {
        public string m_name = "I am mother";
        public void supMethod()
            {
            Console.WriteLine("This is in Super Class : " + m_name);
            }
        }

    ///this is super class
    class Son :Mother
        {
        /*
          public string m_name = "I am mother";  
         */
        public string s_name = "I am son";
        public void supMethod()
            {
            base.supMethod();
            Console.WriteLine("This is in Sub Class : " + s_name);
            //Console.WriteLine("This is in Sub Class : " + m_name);
           
            }       
        }

    }
