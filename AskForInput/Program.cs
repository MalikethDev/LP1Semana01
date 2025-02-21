using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Ask the user for an integer number
            Console.Write("Please enter an integer number: ");

            // Convert the string into an int and store it in a variable
            int number = int.Parse(Console.ReadLine());

            // Ask the user for a real number
            Console.Write("Please enter a real number: ");

            // Convert the string into a float and store it in another variable
            float realNumber = float.Parse(Console.ReadLine());

            // Present the sum of the two numbers requested
            Console.WriteLine($"Adding both numbers: {number + realNumber}");
        }
    }
}
