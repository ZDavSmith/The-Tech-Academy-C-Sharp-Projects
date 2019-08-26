using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithEnums
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter in a day of the week");
                string daysOfWeek = Console.ReadLine();
                Days days = (Days)Enum.Parse(typeof(Days), daysOfWeek, true);

                Console.WriteLine(days);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
        }
    }
}
