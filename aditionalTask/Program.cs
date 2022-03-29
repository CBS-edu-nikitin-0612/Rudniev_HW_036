using System;

namespace aditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[] { new Programmer(), new Manager(), new Director() };
            
            Console.WriteLine("Get access to low level: ");
            foreach (var item in employees)
            {
                Console.WriteLine($"Access allowed for {item.GetType().Name}? = {Company.EnterForLowAccessSection(item)}");
            }
            Console.WriteLine(new string('-', 60));

            Console.WriteLine("Get access to average level: ");
            foreach (var item in employees)
            {
                Console.WriteLine($"Access allowed for {item.GetType().Name}? = {Company.EnterForAverageAccessSection(item)}");
            }
            Console.WriteLine(new string('-', 60));

            Console.WriteLine("Get access to high level: ");
            foreach (var item in employees)
            {
                Console.WriteLine($"Access allowed for {item.GetType().Name}? = {Company.EnterForHighAccessSection(item)}");
            }
        }
    }
}
