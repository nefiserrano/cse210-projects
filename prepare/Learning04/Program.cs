using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Nefi Serrano", "Multiplication");
        string text = assignment.GetSummary();
        Console.WriteLine(text);

        MathAssingment mathAssingment = new MathAssingment("Nefi Serrano", "Fractions", "7.3", "8-19");
        string text1 = mathAssingment.GetHomeworkList();
        Console.WriteLine(mathAssingment.GetSummary());
        Console.WriteLine(text1);

        WritingAssingment writingAssingment = new WritingAssingment("Nefi Serrano", "European History", "The Causes of World War II");
        string text2 = writingAssingment.GetWritingInformation();
        Console.WriteLine(writingAssingment.GetSummary());
        Console.WriteLine(text2);
    }
}