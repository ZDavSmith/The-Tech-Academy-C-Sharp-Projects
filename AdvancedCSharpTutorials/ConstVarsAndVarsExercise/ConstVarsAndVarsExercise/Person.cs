using System;
using System.Collections.Generic;
using System.Text;

namespace ConstVarsAndVarsExercise
{
    public class Person
    {
        
        public Person(int id)
        {
            Id = id;   
        }

        public Person(): this(1)
        {

        }
        public int Id { get; set; }
    }
}
