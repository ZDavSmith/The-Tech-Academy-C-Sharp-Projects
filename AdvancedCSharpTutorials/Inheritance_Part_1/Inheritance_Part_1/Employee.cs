using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Part_1
{
    public class Employee: Person, IQuittable
    {
        public int Id { get; set; }

        public void Quit()
        { 
         Console.WriteLine("I quit");           
        }
    }
}
