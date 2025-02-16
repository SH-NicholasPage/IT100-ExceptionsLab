using System;

namespace Part1;

// A static class cannot be instantiated and is sealed by default.
public static class CountLetters
{
    //Reads a words from the standard input and prints the number of
    //  occurrences of each letter in that word.
    public static void Main()
    {
        int[] counts = new int[26];

        //Get word from the user
        Console.Write("Enter a single word (letters only): ");
        String word = Console.ReadLine()!;

        //Convert to all upper case
        word = word.ToUpper();

        //Count frequency of each letter in string
        for (int i = 0; i < word.Length; i++)
        {
            counts[word[i] - 'A']++;
        }

        //Print frequencies
        Console.WriteLine();
        for (int i = 0; i < counts.Length; i++)
        {
            if (counts[i] != 0)
            {
                Console.WriteLine((char)(i + 'A') + ": " + counts[i]);
            }
        }
    }
}
