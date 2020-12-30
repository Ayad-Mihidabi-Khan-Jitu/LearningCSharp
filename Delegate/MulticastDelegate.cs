/*
Akta delegaet use kore dui ta method e call kora ata tokhon e somvob jokhon
    -method guli void hobe
    -parameter er num abong singnature er hobe
NOTE : Multicast Delegate mainly amra "DelegateOfCalcAB(int a, int b)" er khetre dekhte parbo
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
    {
    internal delegate void DelegateOfCalcAB(int a, int b);
    internal delegate int DelegateOfABMulDiv(int a, int b);
    class MulticastDelegate
        {
        ///internal delegate void DelegateOfCalcAB(int a, int b);
        internal void Addition(int a,int b)
            {
            Console.WriteLine("Addition of A+B = "+(a + b));
            }
        internal void Substraction(int a, int b)
            {
            Console.WriteLine("Substraction of A-B = " + (a - b));
            }

        ///internal delegate int DelegateOfABMulDiv(int a, int b);
        internal int Multiplication(int a, int b)
            {
            return (a * b);
            }
        internal int Division(int a, int b)
            {
            return (a / b);
            }
        static void Main()
            {
            ///Process-1 Method Calling directly
            MulticastDelegate m1 = new MulticastDelegate();
            m1.Addition(1,2);
            m1.Substraction(1,2);

            ///Process-2 Method Calling with the help of delegate
            //DelegateOfCalcAB AddOfAB =new DelegateOfCalcAB(m1.Addition);
            //DelegateOfCalcAB SubOfAB =new DelegateOfCalcAB(m1.Substraction);
            DelegateOfCalcAB AddOfAB = m1.Addition; 
            DelegateOfCalcAB SubOfAB = m1.Substraction;
            AddOfAB(2, 2);
            SubOfAB(2, 2);

            ///Here multicast happens
            ///Process-3 Delegate binding and calling two mathods in one call jokhon method ti void hobe 
            MulticastDelegate m2 = new MulticastDelegate();
            DelegateOfCalcAB CalOfAB = m2.Addition;
            CalOfAB = CalOfAB + m2.Substraction; 
            CalOfAB(20, 15);///method will not be overriden

            ///Here multicast did not heppen due to return type
            ///Process-3 Delegate binding and calling two mathods in one call but method overrides(only one return which is last method's)
            MulticastDelegate m3 = new MulticastDelegate();
            DelegateOfABMulDiv CalOfABMulDiv = m3.Multiplication;
            CalOfABMulDiv = CalOfABMulDiv + m3.Division;
            int muldiv = CalOfABMulDiv(20, 4); ///method will be overriden
            Console.WriteLine(muldiv);
            }

            }
    }
