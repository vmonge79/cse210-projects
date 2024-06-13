using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What is your final grade?");
        string grad = Console.ReadLine();
        int grade = int.Parse(grad);
        int last_digit = grade % 10;

        string letter = " ";

        string sign = " ";

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        if (letter != "F")
        {
            if (last_digit < 3)
            {
                sign = "-";
            }

            else
            {
                if (letter != "F" && letter != "A")
                {
                    if (last_digit >= 7)
                    {
                        sign = "+";
                    }

                }
            }


            Console.WriteLine($"Your grade is {letter}{sign}");

            if (grade >= 70)
            {
                Console.WriteLine("Congratulations! You passed the course!");
            }

            else
            {
                Console.WriteLine("You didn't pass the course. Try harder next time!");


            }
        }
    }
}