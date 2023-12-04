using System.Text.RegularExpressions;
using AdventOfCodeSupport;

namespace AdventOfCode._2023;

public class Day01 : AdventBase
{
    protected override object InternalPart1()
    {
        Console.WriteLine("2023 - Day 1 - Part 1: ");
        
        const string firstDigitPattern = @"\d";
        const string lastDigitPattern = @"\d(?=[^\d]*$)";

        var resultSum = 0;
        
        foreach (string line in Input.Lines)
        {
            var workingString = RegexFactory(line, firstDigitPattern) + RegexFactory(line, lastDigitPattern);
            
            resultSum += int.Parse(workingString);

        }
        
        return resultSum;
    }

    protected override object InternalPart2()
    {
        Console.WriteLine("2023 - Day 1 - Part 2:");
        
        const string regexPattern = @"\d|one|two|three|four|five|six|seven|eight|nine";
        int resultSum = 0;
        
        foreach (string line in Input.Lines)
        {
            var first = Regex.Match(line, regexPattern).ToString();
            var last = Regex.Match(line, regexPattern, RegexOptions.RightToLeft).ToString();

            //convert from letters to digits
            string firstDigit = !char.IsDigit(first[0]) ? ParseMatch(first) : first;

            //convert from letters to digits
            string lastDigit = !char.IsDigit(last[0]) ? ParseMatch(last) : last;

            resultSum += int.Parse(firstDigit + lastDigit);

        }
        
        return resultSum;
    }

    private static string ParseMatch(string st) => st switch
    {
        "" => "0",
        "one" => "1",
        "two" => "2",
        "three" => "3",
        "four" => "4",
        "five" => "5",
        "six" => "6",
        "seven" => "7",
        "eight" => "8",
        "nine" => "9",
        _ => st
    };

    private static string RegexFactory(string input, string pattern)
    {
        return System.Text.RegularExpressions.Regex.Match(input, pattern).Value;
    }
}