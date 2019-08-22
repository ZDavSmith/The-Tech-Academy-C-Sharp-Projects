using System;

namespace ClassProjectTechAcad
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, Please select a number you would like to use for the following three methods: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            userNum = Number.Addition(userNum);
            Console.WriteLine(userNum);


            
        }
    }
}
