using System;

namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
           // Create integer variables of different types
            int age = 27;
            int year = 2025;
            int score = 100;

            // Create variable char with different unicode values
            char o = '\u2764'; // heart symbol
            char p = '\u2620'; // skull symbol
            char q = '\u2603'; // snowman symbol

            // Create real variables of different types
            float real1 = 42.564f;
            double real2 = 84.942;
            decimal real3 = 14.761m;

            // Display the values of the variables
            Console.WriteLine(age);
            Console.WriteLine(year);
            Console.WriteLine(score);
            Console.WriteLine(o);
            Console.WriteLine(p);
            Console.WriteLine(q);
            Console.WriteLine(real1);
            Console.WriteLine(real2);
            Console.WriteLine(real3);
        }
    }
}
