using System;

namespace Inheritance_Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.Id = 1;
            employee.SayName();

            Employee employee2 = new Employee();
            employee2.FirstName = "Sample2";
            employee2.LastName = "Student2";
            employee2.Id = 2;

            Console.WriteLine("The employee ids are the same if the program returns true. \nThe program returns: " + (employee.Id == employee2.Id));



            //IQuittable quittable = new Employee();
            //quittable.Quit();
            
        }
    }
}
