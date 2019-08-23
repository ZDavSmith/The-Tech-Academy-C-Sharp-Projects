using System;
using System.Collections.Generic;
using System.Text;

namespace OptionalParameterClassProj
{
    class mathOperation
    {
        public void Divide(decimal necessaryNum, decimal num = 23)
        {
            try
            {
                decimal answer = necessaryNum / num;
                Console.WriteLine("\n" + necessaryNum + " divided by " + num + " = " + answer);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No, do not divide by 0");
            }
        }
        
    }
}
