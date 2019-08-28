using System;

namespace ConstVarsAndVarsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            const string hello = "Hello";
            Console.WriteLine("{0}! What is your name?", hello);
            var name = Console.ReadLine();

            Console.WriteLine("{0} {1}, your current id will be set to 1. Would you like to change it?", hello, name);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "sure" || answer == "ya")
            {
                Console.WriteLine("Type in a new id number");
                int newId = Convert.ToInt32(Console.ReadLine());
                Person person = new Person(newId);
                Console.WriteLine("Congratulations! Your new id is {0}",person.Id);
            }
            else
            {
                Console.WriteLine("Very well then...");
                Person person = new Person();
                Console.WriteLine("Your id will remain at {0}", person.Id);
            }
        }
    }
}
