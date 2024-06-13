using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PropmptUserNumber();
        int userSquare = SquareNumber(userNumber);
        DisplayResult(userName, userSquare);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name?:");
        string name = Console.ReadLine();
        return name;
    }

    static int PropmptUserNumber()
    {
        Console.Write("What is your favorite number?:");
        string num = Console.ReadLine();
        int number = int.Parse(num);
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.Write($"Brother/Sister {name}, the square of your number is {square}.");
    }
}