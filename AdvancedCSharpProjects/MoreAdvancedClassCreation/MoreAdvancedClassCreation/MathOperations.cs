using System;
using System.Collections.Generic;
using System.Text;

namespace MoreAdvancedClassCreation
{
    class MathOperations
    {
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public decimal Multiply(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public void Multiply(string stringOne)
        {
            try
            {
                int stringOneNum = Convert.ToInt32(stringOne);
                int subtractValidString = stringOneNum - 50;
                Console.WriteLine("Your inputed string was able to be converted. Your number subtracted 50 and now equals " + subtractValidString);
            }

            catch (Exception)
            {
                Console.WriteLine(" ERROR: You typed in an invalid string that could not be converted to the integer data type");
            }
        }
    }
}
