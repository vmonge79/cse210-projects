using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment no1 = new Assignment("Andrea", "WWII");

        Console.WriteLine(no1.GetSumary());

        MathAssigment no2 = new MathAssigment("Vivi", "Functions", "C4", "19-27");

        Console.WriteLine(no2.GetSumary());
        Console.WriteLine(no2.GetHomeworkList());

        WritingAssigment no3 = new WritingAssigment ("Juli", "WWII", "The End of the War");

        Console.WriteLine(no3.GetSumary());
        Console.WriteLine(no3.GetWritingInfo());
    }
}