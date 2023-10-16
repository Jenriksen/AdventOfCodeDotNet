using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using AdventOfCodeSupport;

namespace AdventOfCode._2015;

public class Day05 : AdventBase
{
    protected override void InternalPart1()
    {
        Console.WriteLine("Day 5 - Part 1: ");

        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        HashSet<string> includes = new HashSet<string>();
        
        foreach (string s in InputLines)
        {
            int vowelCount = s.Count(c => vowels.Contains(c));

            if (vowelCount < 3)
                continue;
            foreach (char c in alphabet.Where(c => s.Contains($"{c}{c}")))
                includes.Add(s);
        }

        HashSet<string> niceStrings = new HashSet<string>(includes);
        string[] badStrings = { "ab", "cd", "pq", "xy" };

        foreach (var s in from s in includes from b in badStrings.Where(s.Contains) select s)
        {
            niceStrings.Remove(s);
        }
        

        Console.WriteLine($"Amount of nice strings is: {niceStrings.Count}");

    }

    protected override void InternalPart2()
    {
        Console.WriteLine("Day 5 - Part 1: ");

        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        HashSet<string> includes = new HashSet<string>();
        
        foreach (string s in InputLines)
        {
            int vowelCount = s.Count(c => vowels.Contains(c));

            if (vowelCount < 3)
                continue;
            foreach (char c in alphabet.Where(c => s.Contains($"{c}{c}")))
                includes.Add(s);
        }

        HashSet<string> niceStrings = new HashSet<string>(includes);
        string[] badStrings = { "ab", "cd", "pq", "xy" };

        foreach (var s in from s in includes from b in badStrings.Where(s.Contains) select s)
        {
            niceStrings.Remove(s);
        }
        

        Console.WriteLine($"Amount of nice strings is: {niceStrings.Count}");
    }
}