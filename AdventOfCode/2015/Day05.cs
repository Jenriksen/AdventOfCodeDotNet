using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using AdventOfCodeSupport;

namespace AdventOfCode._2015;

public class Day05 : AdventBase
{
    protected override object InternalPart1()
    {
        Console.WriteLine("Day 5 - Part 1: ");

        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        HashSet<string> includes = new();
        
        foreach (string s in Input.Lines)
        {
            int vowelCount = s.Count(c => vowels.Contains(c));

            if (vowelCount < 3)
                continue;
            foreach (char c in alphabet.Where(c => s.Contains($"{c}{c}")))
                includes.Add(s);
        }

        HashSet<string> niceStrings = new(includes);
        string[] badStrings = { "ab", "cd", "pq", "xy" };

        foreach (string? s in from s in includes from b in badStrings.Where(s.Contains) select s)
        {
            niceStrings.Remove(s);
        }
        

        Console.WriteLine($"Amount of nice strings is: {niceStrings.Count}");

    }

    protected override object InternalPart2()
    {
        // Part 2 remains unsolved. I will have to return to this one.
        Console.WriteLine("Day 5 - Part 2: ");

        var niceStrings = 0;
        var naughtyStrings = 0;

        var InputLinesTest = new List<string>()
        {
            "qjhvhtzxzqqjkmpb",
            "xxyxx",
            "uurcxstgmygtbstg",
            "ieodomkazucvgmuy",
        };
        
        foreach (string line in InputLinesTest)
        {
            if (PairOfAnyTwoLetters(line))
            {
                Console.WriteLine("Found a String with a pair of any two letters.");
                if (RepeatedLetterWithOneLetterBetweenThem(line))
                {
                    Console.WriteLine("Found a niceString!");
                    niceStrings++;
                }
                else
                {
                    Console.WriteLine("Found a naughtyString");
                    naughtyStrings++;
                }
            }
            
            if (RepeatedLetterWithOneLetterBetweenThem(line))
            {
                Console.WriteLine("Found a niceString!");
                niceStrings++;
            }
            else
            {
                Console.WriteLine("Found a naughtyString");
                naughtyStrings++;
            }
        }
        

        Console.WriteLine($"Amount of nice strings is: {niceStrings}");
        Console.WriteLine($"Amount of naughty strings is: {naughtyStrings}");
    }

    private static bool PairOfAnyTwoLetters(string input)
    {
        Regex re = new Regex(@"(..).*?$1");
        return re.Match(input) != Match.Empty;
    }
    
    private static bool RepeatedLetterWithOneLetterBetweenThem(string input)
    {
        Regex re = new Regex(@"(.).?$1");
        return re.Match(input) != Match.Empty;
    }
}