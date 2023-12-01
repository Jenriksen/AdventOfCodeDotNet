using System.Runtime.Intrinsics.X86;
using AdventOfCodeSupport;

namespace AdventOfCode._2015;

public class Day03 : AdventBase
{
    protected override object InternalPart1()
    {
        Console.WriteLine("Day 3 - Part 1: ");
        
        // Create a HashSet as its the most efficient way to handle a unordered set of data without duplicates.
        HashSet<(int X, int Y)> houses = new();
        
        var coordinate = (X: 0, Y: 0);
        houses.Add(coordinate);
        
        foreach (char c in Input.Text)
        {
            coordinate = Move(coordinate, c);
            houses.Add(coordinate);
        }

        Console.WriteLine($"Houses delivered to: {houses.Count}");
        
    }

    protected override object InternalPart2()
    {
        Console.WriteLine("Day 3 - Part 2: ");
        
        // Create a HashSet as its the most efficient way to handle a unordered set of data without duplicates.
        HashSet<(int X, int Y)> housesSanta = new();
        HashSet<(int X, int Y)> housesRoboSanta = new();
        
        var santaCoordinate = (X: 0, Y: 0);
        var roboSantaCoordinate = (X: 0, Y: 0);
        housesSanta.Add(santaCoordinate);
        
        foreach ((char c, int i) in Input.Text.WithIndex())
        {
            
            if (i % 2 == 0)
            {
                santaCoordinate = Move(santaCoordinate, c);
                housesSanta.Add(santaCoordinate);
            }
            else
            {
                roboSantaCoordinate = Move(roboSantaCoordinate, c);
                housesRoboSanta.Add(roboSantaCoordinate);
            }
        }
        
        housesSanta.UnionWith(housesRoboSanta);
        
        Console.WriteLine($"Houses delivered to: {housesSanta.Count} \n");
    }

    private static (int X, int Y) Move((int X, int Y) coordinate, char c)
    {
        switch (c)
        {
            case '^':
                coordinate.X++;
                break;
            case 'v':
                coordinate.X--;
                break;
            case '>':
                coordinate.Y++;
                break;
            case '<':
                coordinate.Y--;
                break;
        }
        return coordinate;
    }
}