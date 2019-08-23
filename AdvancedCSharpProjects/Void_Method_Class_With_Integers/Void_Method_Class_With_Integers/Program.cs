using System;
using System.Collections.Generic;
using System.Text;

namespace Void_Method_Class_With_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now type in a second number");
            int userNum2 = Convert.ToInt32(Console.ReadLine());

            //=======================
            //Instantiating the class
            //========================
           mathOperations Math = new mathOperations();
           Math.Operation(num1: userNum1,num2: userNum2);
           

        }
    }
}
