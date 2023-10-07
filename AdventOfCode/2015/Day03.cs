using AdventOfCodeSupport;

namespace AdventOfCode._2015;

public class Day03 : AdventBase
{
    protected override void InternalPart1()
    {
        // starts on 1 as he delivers a present before the first move.
        int presentsDelivered = 1;
        List<Tuple<int, int>> houses = new List<Tuple<int, int>>();

        foreach (char c in InputText)
        {
            switch (c)
            {
                case '^':
                    
                    break;
                case 'v':
                    break;
                case '>' :
                    break;
                case '<':
                    break;
            }
        }
        
    }

    protected override void InternalPart2()
    {
        throw new NotImplementedException();
    }
}