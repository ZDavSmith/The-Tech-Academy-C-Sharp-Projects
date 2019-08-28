using System;
using System.Collections.Generic;
using System.IO;

namespace DateTimeFunctionsTechExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("The current time is " + currentTime);
            Console.WriteLine("\nPlease enter in a number");
            double numberOfHours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In {0} hours, the time will be {1} ", numberOfHours, currentTime.AddHours(numberOfHours));
            
        }
    }
}
