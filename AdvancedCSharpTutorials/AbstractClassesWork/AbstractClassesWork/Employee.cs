using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassesWork
{
     public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }

    }
}
