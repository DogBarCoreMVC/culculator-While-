using System;

namespace culculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "yes";
            while (choice == "yes")
            {
                Console.Write("Input rount:");
                int rount = (int)double.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                int result = 0;

                while (rount > 0)
                {
                    Console.Write("Input Number:");
                    int number = (int)double.Parse(Console.ReadLine());
                    result += number;
                    rount--;
                }
                Console.WriteLine("\n");
                Console.WriteLine("Result = " + result);

                Console.Write("Want to be active? (yes/on):");
                choice = Console.ReadLine();
                Console.WriteLine("\n");
            }
            Console.WriteLine("Goog Bye");
        }
    }
}
