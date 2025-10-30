using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Erin Stewart", "Algebra");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Kelly Smith", "Geometry", "3", "1-10");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Adam Peterson", "Science", "Weather Patterns");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}