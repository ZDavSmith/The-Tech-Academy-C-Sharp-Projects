using System;

namespace ExceptionHandlingMoreAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please enter in your current age: ");
            bool validAnswer = false;

            do
            {
                try
                {
                    int userAge = Convert.ToInt32(Console.ReadLine());
                    if (userAge > 0)
                    {
                        DateTime pastTime = DateTime.Now.AddYears(-userAge);
                        Console.WriteLine("You were born {0} years ago in {1}", userAge, pastTime.Year);
                        validAnswer = true;
                    }
                    else
                    {
                        throw new Exception();
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a positive number without decimals above zero");
                }
                catch (Exception)
                {
                    Console.WriteLine("How did you mess this up this badly. Reconsider your life choices");
                }
            } while (!validAnswer);
        }
    }
}
