using System;

namespace oop_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ps = new Person();
            Console.WriteLine("Enter a name");
            ps.fName = Console.ReadLine();
            Console.WriteLine("Enter an age");
            ps.age = int.Parse(Console.ReadLine());

            ps.Print();

        }
    }
}
