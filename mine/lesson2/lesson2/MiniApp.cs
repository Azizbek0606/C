//using System;

//public class MiniApp
//{
//    public static void MainCalculatorMethod(string[] args)
//    {
//        List<int> inputNumbers = new List<int>();
//        for (int i = 0; i < 2; i++)
//        {
//            Console.WriteLine("Enter " + (i + 1) + " - number");
//            string input = Console.ReadLine();
//            if (int.TryParse(input, out int number))
//            {
//                inputNumbers.Add(number);
//            }
//            else
//            {
//                Console.WriteLine("Invalid input. Please enter a valid number.");
//                i--;
//            }
//        }
//        if (inputNumbers.Count > 0) { 
//        Console.WriteLine("numbers: " + String.Join(", ", inputNumbers));
//        Console.WriteLine($"Multiply {inputNumbers[0]} and {inputNumbers[1]} : {multiply(inputNumbers[0], inputNumbers[1])}");
//        Console.WriteLine($"add {inputNumbers[0]} and {inputNumbers[1]} : {add(inputNumbers[0], inputNumbers[1])}");
//        Console.WriteLine($"subtract {inputNumbers[0]} and {inputNumbers[1]} : {subtract(inputNumbers[0], inputNumbers[1])}");
//        Console.WriteLine($"divide {inputNumbers[0]} and {inputNumbers[1]} : {divide(inputNumbers[0], inputNumbers[1])}");
//        }
//        else
//        {
//            Console.WriteLine("Numbers not found !!!\nPlease try again and enter numbers first");
//            Environment.Exit(0);
//        }
//    }
//    static int multiply(int a, int b)
//    {
//        return a * b;
//    }
//    static int add(int a, int b)
//    {
//        return a + b;
//    }
//    static int subtract(int a, int b)
//    {
//        return a - b;
//    }
//    static int divide(int a, int b)
//    {
//        if (b == 0)
//        {
//            throw new DivideByZeroException("Cannot divide by zero.");
//        }
//        return a / b;
//    }
//}