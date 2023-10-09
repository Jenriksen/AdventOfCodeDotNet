using System.Text.RegularExpressions;
using AdventOfCodeSupport;

namespace AdventOfCode._2015;

public class Day05 : AdventBase
{
    protected override void InternalPart1()
    {
        Console.WriteLine("Day 5 - Part 1: ");

        int niceStrings = 0;
        
        // regex will kill me...
        string disallowedPattern = @"ab|cd|pq|xy";
        
        // first rule
        string containsAtLeast3WovelsPattern = @"[aeiouy]{3,}";
        
        // second rule
        string duplicateLettersPattern = @"(.)\1+";

        foreach (string line in InputLines)
        {
            if (Regex.IsMatch(line, containsAtLeast3WovelsPattern))
            {
                if (Regex.IsMatch(line, duplicateLettersPattern))
                {
                    if (!Regex.IsMatch(line, disallowedPattern))
                    {
                        niceStrings++;
                    }
                }
            }
        }

        Console.WriteLine($"Amount of nice strings is: {niceStrings}");

    }

    protected override void InternalPart2()
    {
        throw new NotImplementedException();
    }
}