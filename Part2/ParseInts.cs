using System;

namespace Part2;

public static class ParseInts
{
    //Reads a line of text and prints the integers in the line.
    public static void Main()
    {
        int val, sum = 0;
        Console.Write("Enter a line of text: ");
        String line = Console.ReadLine()!;

        String[] tokens = line.Split();

        //Compute a sum of the integers on the line
        for (int i = 0; i < tokens.Length; i++)
        {
            val = int.Parse(tokens[i]);
            sum += val;
        }

        Console.WriteLine("The sum of the integers on this line is " + sum);
    }
}