using AdventOfCodeSupport;

namespace AdventOfCode._2023;

public class Day02 : AdventBase
{
    protected override object InternalPart1()
    {
        Console.WriteLine("2023 - Day 2 - Part 1");
        // Figure out the sum of the game ids from games that are possible with the following cubes:
        // Red: 12
        // Green: 13
        // Blue: 14

        foreach (string line in Input.Lines)
        {
            var gameId = int.Parse(line.Split(":")[0].Last().ToString());
            int[] redCubes;
            int[] greenCubes;
            int[] blueCubes;
            
            // Validate that a current game doesn't contain more cubes than available
            var cubeGames = line.Split(";");

            foreach (string game in cubeGames)
            {
                
            }
        }

        return "";
    }
    

    protected override object InternalPart2()
    {
        throw new NotImplementedException();
    }
}