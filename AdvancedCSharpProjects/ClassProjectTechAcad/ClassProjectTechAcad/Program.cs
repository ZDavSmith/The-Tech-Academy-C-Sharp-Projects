using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProjectTechAcad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a number");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            MathFunctions Math = new MathFunctions();
            int multiplyAnswer = Math.Multiplynum(userNumber);
            Console.WriteLine("Your answer multiplied by 5 = " + multiplyAnswer);

            int addAnswer = Math.Addnum(userNumber);
            Console.WriteLine("Your answer plus 23 = " + addAnswer);

            int subtractAnswer = Math.Subtractnum(userNumber);
            Console.WriteLine("Your answer - 10 = " + subtractAnswer);
            
        }
    }
}
