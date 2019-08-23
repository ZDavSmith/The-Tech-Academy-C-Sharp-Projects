using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWithVoidMethodAndOutputMethod
{
    static class StaticClass
    {
        public static string FoodType;
        public static string FoodValue;
        static StaticClass()
        {
            FoodType = "Meat";
            FoodValue = "Steak";
        }
    }
}
