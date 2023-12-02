using System.Text.RegularExpressions;
using AdventOfCodeSupport;

namespace AdventOfCode._2023;

public class Day01 : AdventBase
{
    protected override object InternalPart1()
    {
        const string firstDigitPattern = @"\d";
        const string lastDigitPattern = @"\d(?=[^\d]*$)";

        var resultSum = 0;
        
        foreach (string line in Input.Lines)
        {
            var workingString = RegexFactory(line, firstDigitPattern) + RegexFactory(line, lastDigitPattern);
            Console.WriteLine(workingString);

            resultSum += int.Parse(workingString);

        }

        Console.WriteLine(resultSum);
        return resultSum;
    }

    protected override object InternalPart2()
    {
        const string regexPattern = @"\d|one|two|three|four|five|six|seven|eight|nine";
        int resultSum = 0;
        foreach (string line in Input.Lines)
        {
            var first = Regex.Match(line, regexPattern);
            var last = Regex.Match(line, regexPattern, RegexOptions.RightToLeft);
            
            
        }
        
    }

    int ParseMatch(string st) => st switch
    {
        "" => 0,
        "one" => 1,
        "two" => 2,
        "three" => 3,
        "four" => 4,
        "five" => 5,
        "six" => 6,
        "seven" => 7,
        "eight" => 8,
        "nine" => 9,
        var d => int.Parse(d)
    };

    string RegexFactory(string input, string pattern)
    {
        return System.Text.RegularExpressions.Regex.Match(input, pattern).Value;
    }
}