using System;
using System.Collections.Generic;
using System.Linq;

namespace Inheritance_Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //LAMBDA EXERCISE
            List<Employee> EmployeeList = new List<Employee>();
            EmployeeList.Add(new Employee("Jon", "Jefferson", 1));
            EmployeeList.Add(new Employee("Kylie", "Stone", 2));
            EmployeeList.Add(new Employee("Jon", "Joseph", 3));
            EmployeeList.Add(new Employee("Joe", "Kulp", 4));
            EmployeeList.Add(new Employee("Carol", "Hafner", 5));
            EmployeeList.Add(new Employee("Tommy", "Lius", 6));
            EmployeeList.Add(new Employee("Kane", "Smith", 7));
            EmployeeList.Add(new Employee("Jordan", "Sterl", 8));
            EmployeeList.Add(new Employee("Joe", "Devoid", 9));
            EmployeeList.Add(new Employee("Elaine", "Anderson", 10));
            foreach (var employee in EmployeeList)
            {
                Console.WriteLine("Employee: {0}", employee.FirstName + " " + employee.LastName + ", Id: " + employee.Id);
            }
            //FOREACH LOOP
            Console.WriteLine("\n\nHere is a list of all Employees with the first name Joe: ");

            foreach (var employee in EmployeeList)
            {
                if (employee.FirstName == "Joe")
                {
                    Console.WriteLine("Employee: {0}", employee.FirstName + " " + employee.LastName + ", Id: " + employee.Id);
                }
            }

            Console.WriteLine("\n\nHere is a list of all Employees with the first name Joe using a lambda expression: ");

            //LAMDA LOOP WITH SAME GOAL
            List<Employee> newList = EmployeeList.Where(x => x.FirstName == "Joe").ToList();

            foreach (Employee employee in newList)
            {
                Console.WriteLine("Employee: {0}", employee.FirstName + " " + employee.LastName + ", Id: " + employee.Id);
            }
            //LAMDA LOOP FOR THE EMPLOYEE ID
            List<Employee> greaterThanFive = EmployeeList.Where(x => x.Id > 5).ToList();
            Console.WriteLine("\n\nHere is the list of employees with an id greater than 5");
            foreach (Employee employee in greaterThanFive)
            {
                Console.WriteLine("Employee: {0}", employee.FirstName + " " + employee.LastName + ", Id: " + employee.Id);
            }


            //Employee<string> Details = new Employee<string>();
            //Details.Things = new List<string>() { "Age: 24", "Height: 5ft. 3in.", "Weight: 12 stone" };


            //Employee<int> Numbers = new Employee<int>();
            //Numbers.Things = new List<int>() { 23, 44, 523 };

            //Console.WriteLine("List of random numbers");
            //foreach (int Number in Numbers.Things)
            //{
            //    Console.WriteLine(Number);
            //}
            //Console.WriteLine("\nEmployee Details");
            //foreach (string Detail in Details.Things)
            //{
            //    Console.WriteLine("{0}\t", Detail);
            //}



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
