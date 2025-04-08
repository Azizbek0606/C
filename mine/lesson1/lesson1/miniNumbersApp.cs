using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniApp
{
    class miniNumbersApp
    {
        public static void MainNumbersMethod(string[] args)
        {
            Console.WriteLine("Welcome to the mini calculator app!");
            List<int> numbers = new List<int>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter: " + (i + 1) + " number");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    i--;
                }
            }
            Console.WriteLine("Numbers: " + string.Join(", ", numbers));

            // Ikkita sonni ko‘paytirish
            int result = miniNumbersApp.multiplication(numbers[0], numbers[1]);
            miniNumbersApp.showResult("Multiplication result: " + result);
        }

        static void showResult(string message)
        {
            Console.WriteLine(message);
        }

        static int multiplication(int a, int b)
        {
            return a * b;
        }

        static int addition(int a, int b)
        {
            return a + b;
        }

        static int subtraction(int a, int b)
        {
            return a - b;
        }

        static int division(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
                return 0;
            }
            return a / b;
        }
    }
}