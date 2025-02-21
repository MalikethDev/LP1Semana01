using System;
using System.Globalization;

namespace Percentagem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            // Ask the user for 4 real numbers between 0 and 4
            Console.WriteLine("Please enter 4 real numbers between 0 and 4:");

            // Print the 4 numbers with two decimal spaces as percentage
            for (int i = 0; i < 4; i++)
            {
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine(number.ToString("P2").PadLeft(10));
            }
        }
    }
}
