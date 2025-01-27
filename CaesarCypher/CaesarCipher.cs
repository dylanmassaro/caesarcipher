using System.Collections;

namespace CaesarCypher;

public static class CaesarCipher
{
    
    public static string Encode(string message, int shift)
    {
        // Check for null input
        if (message == null)
        {
            throw new ArgumentNullException(nameof(message), "Input message cannot be null.");
        }

        // Normalize the shift to be within 0-25
        shift = (shift % 26 + 26) % 26;

        char[] buffer = message.ToCharArray();

        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];

            if (char.IsLetter(letter))
            {
                // Determine the starting point for the character
                char offset = char.IsUpper(letter) ? 'A' : 'a';
                // Calculate shifted character in the range of A-Z or a-z
                letter = (char)((((letter - offset) + shift) % 26) + offset);
            }

            // Assign the modified character back to the buffer
            buffer[i] = letter;
        }

        string outputMessage = new string(buffer);

        outputMessage = outputMessage.ToLower();
        
        return outputMessage;
    }

    public static string Decode(string messsage, int shift)
    {
        return "fart";
    }
    
}