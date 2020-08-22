using System;

namespace Constructor
{
    public class ImplecitConstructor
    {
        int firstNum, SecondNum;
        bool ControllSwitch;
        string firstName;
        /*
        ImplecitConstructor(){
        firstNum=0; 
        SecondNum=0;
        ControllSwitch=false;
        firstName=null;    
        } 
        */

        /*
        ImplecitConstructor(int f, int s, bool c, string fn)
            {//f=12,s=13,c=true,fn="SAIKAT"
            firstNum = f; //12
            SecondNum = s; //13
            ControllSwitch = c; //true
            firstName = fn; //"SAIKAT"
            }
        */
            public static void Main(string[] args)
        {
            ImplecitConstructor valuePrint = new ImplecitConstructor();
            //Constructor.ImplecitConstructor valuePrint = new Constructor.ImplecitConstructor(); //valid
            // ImplecitConstructor valuePrint = new Constructor.ImplecitConstructor(); //also valid
            
            Console.WriteLine(valuePrint.firstName);
            Console.WriteLine(valuePrint.SecondNum);
            Console.WriteLine(valuePrint.firstNum);
            Console.WriteLine(valuePrint.ControllSwitch);
            /*
            valuePrint.firstName = "saikat";
            valuePrint.firstNum = 1;
            valuePrint.SecondNum = 2;
            valuePrint.ControllSwitch = true;
            
            ImplecitConstructor valuePrint = new ImplecitConstructor(12,13,true,"SAIKAT");
            Console.WriteLine(valuePrint.firstName);
            Console.WriteLine(valuePrint.SecondNum);
            Console.WriteLine(valuePrint.firstNum);
            Console.WriteLine(valuePrint.ControllSwitch);

            valuePrint.firstName = "Eshita";
            valuePrint.firstNum = 111;
            valuePrint.SecondNum = 122;
            valuePrint.ControllSwitch = false;

            Console.WriteLine(valuePrint.firstName);
            Console.WriteLine(valuePrint.SecondNum);
            Console.WriteLine(valuePrint.firstNum);
            Console.WriteLine(valuePrint.ControllSwitch);

            ImplecitConstructor valuePrint1 = new ImplecitConstructor(21, 22, true, "JITU");
            Console.WriteLine(valuePrint1.firstName);
            Console.WriteLine(valuePrint1.SecondNum);
            Console.WriteLine(valuePrint1.firstNum);
            Console.WriteLine(valuePrint1.ControllSwitch);
            */
            
            }

    }

}
