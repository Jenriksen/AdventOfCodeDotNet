using AdventOfCodeSupport;

namespace AdventOfCode._2015;

public class Day06 : AdventBase
{
    private enum Action
    {
        Off,
        On,
        Toggle
        
    }

    private static bool[,] lights = new bool[1000, 1000];
    protected override object InternalPart1()
    {
        Console.WriteLine("\n Day 5 - Part 2: ");
        

        int XStartPos;
        int YStartPos;
        int XEndPos;
        int YEndPos;
        
        foreach (string line in Input.Lines)
        {
            // if line[]
            // var splittedLine = line.Split();


        }

        return "";
    }

    protected override object InternalPart2()
    {
        throw new NotImplementedException();
    }
}