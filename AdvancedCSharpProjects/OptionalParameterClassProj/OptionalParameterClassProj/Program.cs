using System;

namespace OptionalParameterClassProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a number");
            decimal necessaryNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Either type in another number to be divided by the first number\nOR simply press enter, and your first number will autmatically divide by 23");
            string line = Console.ReadLine();
            decimal i;
            if(decimal.TryParse(line, out i))
            {
                i = Convert.ToInt32(line);
            }
            else
            {
                i = 23;
            }

            mathOperation Math = new mathOperation();
            Math.Divide(necessaryNum, i);
            




        }
    }
}
