using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your name?");
        string name = Console.ReadLine();

        Console.Write("What is your last_name?");
        string last_name = Console.ReadLine();

        Console.WriteLine($"My name is {last_name}, {name} {last_name}");
    }
}

 