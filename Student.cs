using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement
{
    public class Student
    {
        public string Name { get; set; }

        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name}.");
        }

    }
}
