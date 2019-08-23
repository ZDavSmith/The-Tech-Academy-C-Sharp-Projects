using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWithVoidMethodAndOutputMethod
{
    public class MoreWithMethods
    {
        public int Result { get; set; }
        public int ResultTwo { get; set; }
        public int ResultThree { get; set; }

        public void DivideByTwo(int numOne)
        {
            Result = numOne / 2;
        }

        public void MultiplyByTwo(int numTwo, out int timesMultiplied, int times)
        {
            timesMultiplied = 0;
            for (int i = 0; i < times; i++)
            {
              timesMultiplied++;
              numTwo = numTwo * 2;
            }
            ResultTwo = numTwo;
            
        }

        public void DivideByTwo(int numOne, int numTwo)
        {
            ResultThree = numOne / numTwo;
        }

    }
}
