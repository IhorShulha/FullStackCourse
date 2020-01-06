using System;

namespace Task3
{
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Text from ClassTaker";
        }

        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "Text from structTaker";
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();

            //myClass.change = "Text2 ...";
           //myStruct.change = "Anywhere";

            // *** //
            ClassTaker(myClass);
            
            myStruct.StruktTaker();

            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);

        }
    }
}
