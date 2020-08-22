using System;

namespace Constructor
{
    public class ExplicitConstructor
    {
        string name;
        int number;
       public ExplicitConstructor()
        {
            //Console.WriteLine("Yes it is Explicit Constructor");
            name = "Jitu";
            number = 100;
        }
        public static void Main()
        {
           ExplicitConstructor MsgPrint1 = new ExplicitConstructor();
            Console.WriteLine(MsgPrint1); // It will print the address of the Object MsgPrint
            Console.WriteLine(MsgPrint1.name);
            Console.WriteLine(MsgPrint1.number);
            // ExplicitConstructor MsgPrint1 = new Constructor.ExplicitConstructor();
            //Constructor.ExplicitConstructor MsgPrint = new Constructor.ExplicitConstructor();  
            ExplicitConstructor MsgPrint2 = new ExplicitConstructor();
            Console.WriteLine(MsgPrint2); // It will print the address of the Object MsgPrint
            Console.WriteLine(MsgPrint2.name);
            Console.WriteLine(MsgPrint2.number);
            }

    }
}
