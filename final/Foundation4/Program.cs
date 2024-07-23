using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime ST1 = new DateTime(2024, 7, 22, 10, 0, 0);
        DateTime ET1 = new DateTime(2024, 7, 22, 10, 45, 0);
        DateTime ST2 = new DateTime(2024, 7, 21, 08, 0, 0);
        DateTime ET2 = new DateTime(2024, 7, 21, 08, 55, 0);


        Running r1 = new Running(ET1, ST1, 5000);
        Running r1 = new Running(ET2, ST2, 8000);
        Cycling c1 = new Running(ET2, ST2, 45);
        Cycling c2 = new Running(ET1, ST1, 55);
        Swimming s1 = new Running(ET2, ST2, 30);
        Swimming s2 = new Running(ET1, ST1, 40);

        List<Excercise> excersises = new List<Excercise>{r1, r2, c1, c2, s1, s2};

        foreach (Excersise ex in excersises)
        {
            ex.GetSummary();
        }
    }
}