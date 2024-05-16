using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplicacion");
        string summary = assignment.GetSummary();
        Console.WriteLine(summary);

        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7", "Problems 8-19");
        string summary2 = mathAssignment.GetSummary();
        Console.WriteLine(summary2);
        string mathsummary = mathAssignment.GetHomeWorkList();
        Console.WriteLine(mathsummary);

        WrittingAssignment writtingAssignment = new WrittingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        string writtingsummary = writtingAssignment.GetWrittingInformation();
        string summary3 = writtingAssignment.GetSummary();
        Console.WriteLine(summary3);
        Console.WriteLine(writtingsummary);
    }
}