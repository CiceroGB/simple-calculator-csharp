using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {

            float v1;
            float v2;
            Console.WriteLine("Console Calculator in C#\n");

            Console.WriteLine("Type a number, and then press Enter");
            v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Type another number, and then press Enter");
            v2 = float.Parse(Console.ReadLine());


            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {v1} + {v2} = " + (v1 + v2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {v1} - {v2} = " + (v1 - v2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {v1} * {v2} = " + (v1 * v2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {v1} / {v2} = " + (v1 / v2));
                    break;
                default: Menu(); break;
            }
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }

    }
}
