using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
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
        }
    }
}
