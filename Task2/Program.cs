using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            Console.WriteLine($"Call OldMethod1: {myClass.OldMethod1()}");
            Console.WriteLine($"Call OldMethod2: {myClass.OldMethod2()}");
        }
    }
}
