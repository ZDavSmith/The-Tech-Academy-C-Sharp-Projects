using System;
using System.Collections.Generic;
using System.IO;

namespace UsingLogstoFilesTechExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in a number");
            string number = Console.ReadLine();

            File.WriteAllText(@"C:\Users\Zachary\Logs\log.txt", number);
            string text = File.ReadAllText(@"C:\Users\Zachary\Logs\log.txt");
            Console.WriteLine("The number logged in the text file is " + text);

        }
    }
}
