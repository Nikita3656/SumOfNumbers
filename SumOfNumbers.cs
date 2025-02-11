using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Asking the user to enter a list of integers
        Console.WriteLine("Enter a list of integers, separated by spaces:");
        string input = Console.ReadLine();

        // Convert the input string to an array of integers
        int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

        // Calculate the sum of the numbers in the array
        int sum = numbers.Sum();

        // Output the result
        Console.WriteLine($"The sum of the numbers is: {sum}");
    }
}
