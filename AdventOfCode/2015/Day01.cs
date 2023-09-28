using AdventOfCodeSupport;
using System.Collections.Generic;

namespace AdventOfCode._2015;

public class Day01 : AdventBase
{
    protected override void InternalPart1()
    {
        int floor = 0;
        foreach (char c in InputText)
        {
            if (c == '(')
            {
                floor++;
            }
            else
            {
                floor--;
            }
        }

        Console.WriteLine($"Amount of floors is: {floor}");
    }

    protected override void InternalPart2()
    {
        int floor = 0;
        int basementIndex = 0;
        foreach (var (c, index) in InputText.WithIndex())
        {
            if (c == '(')
            {
                floor++;
            }
            else
            {
                floor--;
            }

            if (floor == -1)
            {
                basementIndex = index;
                break;
            }
        }

        Console.WriteLine($"First time Santa enters the basement is: {basementIndex + 1}");
    }
    
    
}

// Extension method for using foreach with index

public static class EnumExtension {
    public static IEnumerable<(T item, int index)> WithIndex<T>(this IEnumerable<T> self)       
        => self.Select((item, index) => (item, index));
}