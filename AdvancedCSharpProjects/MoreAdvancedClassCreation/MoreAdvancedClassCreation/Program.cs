using System;

namespace MoreAdvancedClassCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            //First method called 

            Console.WriteLine("Type in a random number");
            int userNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number to multiply the first number by");
            int userNum2 = Convert.ToInt32(Console.ReadLine());

            MathOperations MultiplyNums = new MathOperations();
            int outputNum1 = MultiplyNums.Multiply(userNum, userNum2);
            Console.WriteLine("Your numbers multiplied together = " + outputNum1);

            //Second Method

            Console.WriteLine("\nType in a random number with a decimal");
            decimal userDec = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter a number to add the first number to, also with a decimal");
            decimal userDec2 = Convert.ToDecimal(Console.ReadLine());

            MathOperations AddDecimals = new MathOperations();
            decimal outputNum2 = AddDecimals.Multiply(userDec, userDec2);
            Console.WriteLine("Your decimal numbers added together = " + outputNum2);

            //Third Method

            Console.WriteLine("\nThis next part of the program is for string to int conversion testing.\nType in a number to see the conversion work properly.\nType in a word or phrase to see the conversion work inproperly.");
            string userWord = Console.ReadLine();

            MathOperations convertString = new MathOperations();
            convertString.Multiply(userWord);
        }
    }
}
