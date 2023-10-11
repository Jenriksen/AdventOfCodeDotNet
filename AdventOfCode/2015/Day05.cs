using System.Text.RegularExpressions;
using AdventOfCodeSupport;

namespace AdventOfCode._2015;

public class Day05 : AdventBase
{
    protected override void InternalPart1()
    {
        Console.WriteLine("Day 5 - Part 1: ");
        List<string> testInput = new()
        {
            "ugknbfddgicrmopn",
            "aaa",
            "jchzalrnumimnmhp",
            "haegwjzuvuyypxyu",
            "dvszwmarrgswjxmb"
        };
        
        // regex will kill me...
        string disallowedPattern = @"ab|cd|pq|xy";
        
        // first rule
        string containsAtLeast3WovelsPattern = @"[aeiouy]{3,}";
        
        // second rule
        string duplicateLettersPattern = @"(.)\1+";

        //foreach (string line in InputLines)
        int niceStrings = testInput.Where(line => Regex.IsMatch(line, containsAtLeast3WovelsPattern))
            .Where(line => Regex.IsMatch(line, duplicateLettersPattern))
            .Count(line => !Regex.IsMatch(line, disallowedPattern));

        Console.WriteLine($"Amount of nice strings is: {niceStrings}");

    }

    protected override void InternalPart2()
    {
        throw new NotImplementedException();
    }
}