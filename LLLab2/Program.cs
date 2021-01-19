using System;

namespace LLLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator();
            string keepGoing;

            do
            {

                Console.Write("Enter length:");
                var length = double.Parse(Console.ReadLine());
                Console.Write("Enter Width:");
                var width = double.Parse(Console.ReadLine());
                Console.WriteLine($"Area: {length * width}");
                Console.WriteLine($"Perimeter: {length + length + length + length}");
                Console.WriteLine("Would you like to Continue? y/n");
                keepGoing = Console.ReadLine();


            } while (keepGoing == "y");

        }

        static void Creator()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome To Grand Circus's Room Detail Generator\nCreated By Darrius Horton");
            Console.ResetColor();
        }
    }
}

