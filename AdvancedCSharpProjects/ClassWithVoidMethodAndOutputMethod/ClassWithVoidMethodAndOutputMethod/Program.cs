using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWithVoidMethodAndOutputMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //First Method
            Console.WriteLine("Enter an integer");
            int userInt = Convert.ToInt32(Console.ReadLine());

            MoreWithMethods Divide = new MoreWithMethods();
            Divide.DivideByTwo(userInt);
            Console.WriteLine(userInt + " divided by 2 = " + Divide.Result);

            //Second Method w/Outputs
            Console.WriteLine("Type in a number");
            int userIntTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many times would you like to multipy that number by 2 by?");
            int iterations = Convert.ToInt32(Console.ReadLine());


            MoreWithMethods Multiply = new MoreWithMethods();
            Multiply.MultiplyByTwo(userIntTwo, out int timesMultiplied, iterations);
            Console.WriteLine("Your number is " + Multiply.ResultTwo);
            Console.WriteLine("Number of iterations: " + timesMultiplied);

            //Overloading First Method
            Console.WriteLine("\nType in another number");
            int userIntThree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type in a number other than 0 for it to be divided by");
            int userIntFour = Convert.ToInt32(Console.ReadLine());

            MoreWithMethods DivideTwo = new MoreWithMethods();
            DivideTwo.DivideByTwo(userIntThree, userIntFour);
            Console.WriteLine(userIntThree + " divided by " + userIntFour + " equals " + DivideTwo.ResultThree);

            //Static Class
            Console.WriteLine("\nStatic Class exercise");
            Console.WriteLine("My favorite type of " + StaticClass.FoodType + " is " + StaticClass.FoodValue);
            Console.Read();
        }

    }
}
