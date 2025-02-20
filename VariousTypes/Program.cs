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
            char heart = '\u2764'; // heart symbol
            char skull = '\u2620'; // skull symbol
            char snowman = '\u2603'; // snowman symbol

            // Create real variables of different types
            float real1 = 42.564f;
            double real2 = 84.942;
            decimal real3 = 14.761m;

            // Create two boolean variables
            bool big = true;
            big = 5 < 3;
            bool small = false;
            small = 2 > 1;

            // Display the values of the variables
            Console.WriteLine(age);
            Console.WriteLine(year);
            Console.WriteLine(score);
            Console.WriteLine(heart);
            Console.WriteLine(skull);
            Console.WriteLine(snowman);
            Console.WriteLine(real1);
            Console.WriteLine(real2);
            Console.WriteLine(real3);
            Console.WriteLine(big);
            Console.WriteLine(small);
        }
    }
}
