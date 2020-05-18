using System;

namespace lommeregner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write your first number");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("write your second number");
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("the result is "+ (tal1+tal2));
        }
    }
}
