using AdventOfCodeSupport;

namespace AdventOfCode._2015;

public class Day02 : AdventBase
{
    protected override void InternalPart1()
    {
        Console.WriteLine("Day 2 - Part 1:");
        int squareFeetWrappingPaper = 0;
        string[] inputLinesExamples = new[] { "2x3x4", "1x1x10" };
        
        // InputLines
        foreach (string s in InputLines)
        {
            var dimensions = s.Split("x");
            var dimensionsInt = dimensions.Select(int.Parse).ToArray();
            List<int> extraPaperRequired = new List<int>();
            int a = dimensionsInt[0];
            int b = dimensionsInt[1];
            int c = dimensionsInt[2];
            extraPaperRequired.Add(a * b);
            extraPaperRequired.Add(b * c);
            extraPaperRequired.Add(a * c);

            
            // calculate wrapping paper
            int subtotal = (a * b * 2 + b * c * 2 + a * c * 2);
            int extraWrappingPaper = extraPaperRequired.Min();
            subtotal += extraWrappingPaper;
            Console.WriteLine($"Wrapping paper required for this present: {subtotal}");
            
            squareFeetWrappingPaper += subtotal;
        }
        
        Console.WriteLine($"Amount of wrapping paper required: {squareFeetWrappingPaper} in sqF");
    }

    protected override void InternalPart2()
    {
        throw new NotImplementedException();
    }
}