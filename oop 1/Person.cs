using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_1
{
    class Person
    {
        public string fName;
        public string lName;
        public int age;

        public void Print()
        {
            Console.WriteLine($"age: {age}");
            Console.WriteLine("\n");
            if (fName.Length > 5)
            {
                Console.WriteLine($"{fName}");
                Console.WriteLine($"Your name consists of {fName.Length} Letters");
                return;
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
