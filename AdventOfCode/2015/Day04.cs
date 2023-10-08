using AdventOfCodeSupport;
using System.Security.Cryptography;
using System.Text;

namespace AdventOfCode._2015;

public class Day04 : AdventBase
{
    protected override void InternalPart1()
    {
        Console.WriteLine("Day 4 - Part 1: ");
        
        // Find md5 hash with secretKey that starts with five zeroes
        // Create a while loop to iterate until it is found
        string secretKey = InputText;
        long numberAdded = 0;
        string generatedHash = "";
        
        using (MD5 md5Hash = MD5.Create())
        {
            while (!generatedHash.StartsWith("00000"))
            {
                numberAdded++;
                generatedHash = GetMd5Hash(md5Hash, secretKey + numberAdded);
            }
        }

        Console.WriteLine($"Number added to hash is: {numberAdded}");
        Console.WriteLine($"Hash is: {generatedHash}");
    }

    protected override void InternalPart2()
    {
        Console.WriteLine("Day 4 - Part 2: ");
        
        // Find md5 hash with secretKey that starts with five zeroes
        // Create a while loop to iterate until it is found
        string secretKey = InputText;
        long numberAdded = 0;
        string generatedHash = "";
        
        using (MD5 md5Hash = MD5.Create())
        {
            while (!generatedHash.StartsWith("000000"))
            {
                numberAdded++;
                generatedHash = GetMd5Hash(md5Hash, secretKey + numberAdded);
            }
        }

        Console.WriteLine($"Number added to hash is: {numberAdded}");
        Console.WriteLine($"Hash is: {generatedHash} \n");
    }

    static string GetMd5Hash(MD5 md5Hash, string input)
    {
        byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
        StringBuilder sBuilder = new StringBuilder();

        for (int i = 0; i < data.Length; i++)
        {
            sBuilder.Append(data[i].ToString("X2"));
        }

        return sBuilder.ToString();
    }
}