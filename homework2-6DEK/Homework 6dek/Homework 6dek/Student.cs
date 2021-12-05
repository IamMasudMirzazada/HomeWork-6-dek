using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6dek
{
    class Student:Person
    {





        public void Study()
        {
            Console.WriteLine("I am studying");
        }
        public void ShowAge(int age)
        {
            Console.WriteLine( $"My Age is: {age} years old");
        }
    }
}
