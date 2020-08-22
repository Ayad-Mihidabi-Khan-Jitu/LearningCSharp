using System;

namespace Constructor
{
    public class ParameterizedConstructor
    {
        int i,j;
        public ParameterizedConstructor(int i,double j)
        {
            this.j = (int)j;
            this.i = i;
            Console.WriteLine("First Number is : " + i);
            Console.WriteLine("Second Number is : " + this.j);
          }

        public ParameterizedConstructor(int num1,int num2)
        {
            i = num1; 
            j = num2;
            Console.WriteLine("First Number and Second Number is : " + num1+" and "+num2);
        }
        public void Display()
        {
            Console.WriteLine("The value of i :" + i);
        }

        public void Display(int num)
        {
            int disNum = num;
            Console.WriteLine("The value of disNum:" + disNum);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Parameterized");
            ParameterizedConstructor FirstPrint =new ParameterizedConstructor(15,10.56);
            ParameterizedConstructor SecondPrint = new ParameterizedConstructor(20,100); //construcotr overloading
            /*
            // FirstPrint = SecondPrint;
            FirstPrint.Display();
            SecondPrint.Display();
            SecondPrint.Display(50);//method overloading
            //Console.WriteLine(FirstPrint);
            //Console.WriteLine(SecondPrint);
            ParameterizedConstructor jhan;
            jhan = FirstPrint;
            jhan.Display();
            */
        }
    }
}
