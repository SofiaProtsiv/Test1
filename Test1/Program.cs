using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string name = "Tom";
            int age = 33;
            bool isEmployed = false;
            double weight = 78.65;*/

            /* Console.WriteLine($"Name: {name} ");
             Console.WriteLine($"Age: {age} ");
             Console.WriteLine($"Weight: {weight} ");
             Console.WriteLine($"Work: {isEmployed} ");*/

            /*Console.WriteLine($"Name: {name} Age: {age} Weight: {weight} Work: {isEmployed}");*/

            /*Console.WriteLine("Name: {0} Age: {2} Weight: {1}kg'', name, weight, age");*/

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            char age = (char)Console.Read();
            Console.Write("Enter your height: ");
            char height = (char)Console.Read();
            Console.Write("Enter your salary: ");
            char salary = (char)Console.Read();
            Console.WriteLine("Name: {0} Age: {2} Height: {1}m Salary: {}$", name, age, height, salary);
        }
    }
}
