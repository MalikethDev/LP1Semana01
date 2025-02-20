using System;
using System.Diagnostics.Contracts;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Add the following variables
            double xx = 1.23456;
            int ii = 19;

            // Print xx as a real number with 2 decimal places
            Console.WriteLine(xx.ToString("F2"));
            // Print xx as a percentage with 1 decimal place
            Console.WriteLine(xx.ToString("P1"));

            // Print ii as a hexadecimal number
            Console.WriteLine(ii.ToString("X"));
            // Print ii as a currency
            Console.WriteLine(ii.ToString("C"));

            // Add some string variables
            // Test multiple escape and Unicode characters
            string s = "Um tab\t e um copyright\u03A9";
            string s2 = "Uma quebra de linha\n e um \"aspas\"";
            string s3 = "Uma barra invertida \\ e um sinal de porcentagem\u0025";
            string s4 = "Um caractere de escape \x5C e um \x23";

            Console.WriteLine(s);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);

            // Add more string variables by concatenating them
            string s5 = "Hello";
            string s6 = "World";
            string s7 = s5 + " " + s6;
            Console.WriteLine(s7);

            string s8 = 2 + 2 + " = 2 + 2";
            Console.WriteLine(s8);

            string s9 = "ABC " + 123 + " Primeiras letras e números";
            Console.WriteLine(s9);

            // Add string variables by using string interpolation
            string s10 = "Hello";
            string s11 = "World";
            string s12 = $"{s10} {s11}";
            Console.WriteLine(s12);

            string s13 = $"Valor de 2 + 2 é {2 + 2}";
            Console.WriteLine(s13);

            string s14 = $"ABC {1 + 1 + 1} Primeiras tres letras";
            Console.WriteLine(s14);
        }
    }
}
