using miniApp;
using System;
using System.Collections.Generic;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            miniNumbersApp.MainNumbersMethod(args);
            //List<string> promptList = new List<string>() { "Enter Name", "Enter Age", "Are You Student? <true> or <false>" };
            //List<string> userInfo = new List<string>();

            //foreach (string prompt in promptList)
            //{
            //    string userInput = GetInfoFromUser(prompt);
            //    userInfo.Add(userInput);
            //}

            //Console.WriteLine("\nUser Info:");
            //for (int i = 0; i < userInfo.Count; i++)
            //{
            //    switch (i)
            //    {
            //        case 0:
            //            Console.WriteLine($"Name: {userInfo[i]}");
            //            break;
            //        case 1:
            //            Console.WriteLine($"Age: {userInfo[i]}");
            //            break;
            //        case 2:
            //            if (bool.TryParse(userInfo[i], out bool isStudent))
            //            {
            //                Console.WriteLine(isStudent ? "You are student" : "You are not student");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Invalid student status input");
            //            }
            //            break;
            //    }
            //}
        //static string GetInfoFromUser(string message)
        //{
        //    Console.Write(message + ": ");
        //    return Console.ReadLine();
        //}
        }
    }
}