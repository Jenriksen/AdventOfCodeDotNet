using AdventOfCodeSupport;
using System.Security.Cryptography;

namespace AdventOfCode._2015;

public class Day04 : AdventBase
{
    protected override void InternalPart1()
    {
        // Find md5 hash with secretKey that starts with five zeroes
        // Create a while loop to iterate until it is found
        string secretKey = InputText;
        long numberAdded = 0;
        
        while (md5Hash)
        using (MD5 md5Hash = MD5.Create())
        {
            
        }
    }

    protected override void InternalPart2()
    {
        throw new NotImplementedException();
    }
}