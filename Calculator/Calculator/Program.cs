using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor = Blue;
            Console.ForegroundColor = ConsoleColor = Yellow;
            
            int num1 = 0; int num2 = 0;

            Console.WriteLine("Do a calculation\r");
            Console.WriteLine("------------------\n");

            Console.WriteLine("Go ahead and try it");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type another number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an option:");
            Console.WriteLine("\ta. Add");
            Console.WriteLine("\tb. Subtract");
            Console.WriteLine("\tc. Multiply");
            Console.WriteLine("\td. Divide");
            Console.Write("You chose: ");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"{num1} + {num2} = " + (num1 + num2));
                    break;
                case "b":
                    Console.WriteLine($"{num1} - {num2} = " + (num1 - num2));
                    break;
                case "c":
                    Console.WriteLine($"{num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"{num1} / {num2} = " + (num1 / num2));
                    break;
            }

            Console.WriteLine("Close console.");
            Console.ReadKey();
        }
    }
}
