using System.Collections.Immutable;
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
        Console.WriteLine("Day 2 - Part 1:");
        int feetRibbon = 0;
        string[] InputLinesExamples = new[] { "2x3x4", "1x1x10" };
        
        // InputLines
        foreach (string s in InputLinesExamples)
        {
            int[] dimensions = s.Split("x").Select(int.Parse).Order().ToArray();
            
            
            // calculate length of ribbon
            // start by finding the 2 shortest sides of the box
            // do it by sorting the list and only using the 2 lowest numbers then
            // then add a, b and c together for the length used for the bow
            
            var boxLength = dimensions[0] * 2 + dimensions[1] * 2;
            var tieLength = dimensions.Sum();

            var subtotal = boxLength + tieLength;
            Console.WriteLine($"Amount of ribbon required for this present: {subtotal}f");
        }
        
        Console.WriteLine($"Amount of ribbon required: {feetRibbon}f");
    }
}