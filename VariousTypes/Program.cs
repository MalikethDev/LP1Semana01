using System;

namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
           // Create integer variables of different types
            int a = 10;
            uint b = 20U;
            short c = 30;
            ushort d = 40;
            long e = 50L;
            ulong f = 60UL;
            byte g = 70;
            sbyte h = 80;
            char i = 'A';
            float j = 3.1415f;
            double k = 100;
            decimal l = 110.5m;
            bool m = true;
            string n = "Hello";

            // Create variable char with different unicode values
            char o = '\u2764'; // heart symbol
            char p = '\u2620'; // skull symbol
            char q = '\u2603'; // snowman symbol

            // Display the values of the variables
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.WriteLine(l);
            Console.WriteLine(m);
            Console.WriteLine(n);
            Console.WriteLine(o);
            Console.WriteLine(p);
            Console.WriteLine(q);
        }
    }
}
