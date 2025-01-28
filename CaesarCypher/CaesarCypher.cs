using System.Collections;

namespace CaesarCypher;

public static class CaesarCypher
{
    public static readonly Dictionary<char, double> LetterFrequencies = new Dictionary<char, double>()
    {
        {'E', 12.70}, {'T', 9.06}, {'A', 8.17}, {'O', 7.51},
        {'I', 6.97}, {'N', 6.75}, {'S', 6.33}, {'H', 6.09},
        {'R', 5.99}, {'D', 4.25}, {'L', 4.03}, {'C', 2.78},
        {'U', 2.76}, {'M', 2.41}, {'W', 2.36}, {'F', 2.23},
        {'G', 2.02}, {'Y', 1.97}, {'P', 1.93}, {'B', 1.49},
        {'V', 0.98}, {'K', 0.77}, {'X', 0.15}, {'J', 0.15},
        {'Q', 0.10}, {'Z', 0.07}
    };
    
    public static string Encode(string message, int shift)
    {
        if (message == null)
        {
            throw new ArgumentNullException(nameof(message), "Input message cannot be null.");
        }

        shift = (shift % 26 + 26) % 26;

        char[] buffer = message.ToCharArray();

        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];

            if (char.IsLetter(letter))
            {
                char offset = char.IsUpper(letter) ? 'A' : 'a';
                letter = (char)((((letter - offset) + shift) % 26) + offset);
            }

            buffer[i] = letter;
        }

        string outputMessage = new string(buffer);

        outputMessage = outputMessage.ToLower();
        
        return outputMessage;
    }

    public static string Decode(string message, int shift)
    
    {
        if (message == null)
        {
            throw new ArgumentNullException(nameof(message), "Input message cannot be null.");
        }

        shift = (shift % 26 + 26) % 26;

        char[] buffer = message.ToCharArray();

        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];

            if (char.IsLetter(letter))
            {
                char offset = char.IsUpper(letter) ? 'A' : 'a';
                letter = (char)((((letter - offset) - shift + 26) % 26) + offset);
            }

            buffer[i] = letter;
        }

        string outputMessage = new string(buffer);

        outputMessage = outputMessage.ToLower();

        return outputMessage;
    }

    public static string Crack(string message)
    {
        int[] letterCounts;
        int maxCount = 0;
        string bestGuess = "";
        int bestShift = 0;

        for (int shift = 0; shift < 26; shift++)
        {
            string decoded = Decode(message, shift);
            letterCounts = new int[26]; 

            foreach (char c in decoded.ToLower())
            {
                if (char.IsLetter(c))
                {
                    letterCounts[c - 'a']++;
                }
            }

            if (shift == 0 || letterCounts['e' - 'a'] > maxCount)
            {
                maxCount = letterCounts['e' - 'a'];
                bestGuess = decoded;
                bestShift = shift;
            }
        }

        Console.WriteLine("Most likely shift is: " + bestShift);
        bestGuess = bestGuess.ToLower();
        return bestGuess;
    }
}
    