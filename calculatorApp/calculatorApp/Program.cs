//Anelyne 2-27-24

using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("Welcome to Calculator App!");
            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");

            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();

            double result = 0;

            switch (operation)
            {
                case '1':
                    result = num1 + num2;
                    break;
                case '2':
                    result = num1 - num2;
                    break;
                case '3':
                    result = num1 * num2;
                    break;
                case '4':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation selected.");
                    return;
            }

            Console.WriteLine($"Result: {result}");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

