using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a number, type 0 when finished:");

        int number = int.Parse(Console.ReadLine());

        while (number != 0)
        {
            numbers.Add(number);

            Console.WriteLine("Enter another number, type 0 when finished:");
            number = int.Parse(Console.ReadLine());
        }

        int sum = numbers.Sum();
        double average = numbers.Count > 0 ? numbers.Average() : 0;
        int max = numbers.Count > 0 ? numbers.Max() : 0;

        Console.WriteLine($"The sum is {sum}.");
        Console.WriteLine($"The average is {average}.");
        Console.WriteLine($"The largest number is {max}.");
    }
}
