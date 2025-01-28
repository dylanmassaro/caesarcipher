using System.Collections;

namespace CaesarCypher;

public static class CaesarCipher
{
    
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

    
}