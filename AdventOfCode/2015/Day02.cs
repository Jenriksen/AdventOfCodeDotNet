using System.Collections.Immutable;
using AdventOfCodeSupport;

namespace AdventOfCode._2015;

public class Day02 : AdventBase
{
    protected override void InternalPart1()
    {
        Console.WriteLine("Day 2 - Part 1:");
        int squareFeetWrappingPaper = 0;
        //string[] inputLinesExamples = new[] { "2x3x4", "1x1x10" };
        
        // InputLines
        foreach (string s in InputLines)
        {
            string[] dimensions = s.Split("x");
            int[] dimensionsInt = dimensions.Select(int.Parse).ToArray();
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
            
            squareFeetWrappingPaper += subtotal;
        }
        
        Console.WriteLine($"Amount of wrapping paper required: {squareFeetWrappingPaper} in sqF \n");
    }

    protected override void InternalPart2()
    {
        Console.WriteLine("Day 2 - Part 2:");
        var feetRibbon = 0;
        
        // InputLines
        foreach (string s in InputLines)
        {
            int[] dimensions = s.Split("x").Select(int.Parse).Order().ToArray();

            var subtotal = dimensions[0] * 2 + dimensions[1] * 2;
            var bowTieLength = dimensions[0] * dimensions[1] * dimensions[2];

            subtotal += bowTieLength;
            feetRibbon += subtotal;
        }
        
        Console.WriteLine($"Amount of ribbon required: {feetRibbon}f \n");
    }
}