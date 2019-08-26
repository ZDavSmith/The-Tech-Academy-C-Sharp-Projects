using System;
using System.Collections.Generic;

namespace Inheritance_Part_1
{
    class Program
    {
        static void Main(string[] args)
        {


            Employee<string> Details = new Employee<string>();
            Details.Things = new List<string>() { "Age: 24", "Height: 5ft. 3in.", "Weight: 12 stone" };


            Employee<int> Numbers = new Employee<int>();
            Numbers.Things = new List<int>() { 23, 44, 523 };

            Console.WriteLine("List of random numbers");
                foreach (int Number in Numbers.Things)
                {
                    Console.WriteLine(Number);
                }
            Console.WriteLine("\nEmployee Details");
                foreach (string Detail in Details.Things)
                {
                    Console.WriteLine("{0}\t", Detail);
                }



                //Employee employee = new Employee();
                //employee.FirstName = "Sample";
                //employee.LastName = "Student";
                //employee.Id = 1;
                //employee.SayName();

                //Employee employee2 = new Employee();
                //employee2.FirstName = "Sample2";
                //employee2.LastName = "Student2";
                //employee2.Id = 2;

                //Console.WriteLine("The employee ids are the same if the program returns true. \nThe program returns: " + (employee.Id == employee2.Id));



                //IQuittable quittable = new Employee();
                //quittable.Quit();

            }
    }
}
