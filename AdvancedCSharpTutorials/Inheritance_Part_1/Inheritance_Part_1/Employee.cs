using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Part_1
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public List<int> Things { get; set; }
        public void Quit()
        {
            Console.WriteLine("I quit");
        }


        public Employee(string FirstName, string LastName, int id)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            Id = id;
        }


        //public static bool operator ==(Employee employee, Employee employee2)
        //{
        //    bool sameId = false;
        //    if (employee.Id == employee2.Id)
        //    {
        //       return sameId = true;

        //    }
        //    else
        //    {
        //        return sameId = false;
        //    }
        //}


        //public static bool operator!=(Employee employee, Employee employee2)
        //{
        //    bool sameId = true;
        //    if (employee.Id==employee2.Id)
        //    {
        //        return sameId = false;
        //    }
        //    else
        //    {
        //        return sameId = true;
        //    }
        //}
    }


}
