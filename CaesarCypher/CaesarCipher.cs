using System.Collections;

namespace CaesarCypher;

public static class CaesarCipher
{
    
    public static string Encode(string message, int shift)
    {
        shift = shift % 26;

        char[] buffer = message.ToCharArray();

        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];

            if (char.IsLetter(letter))
            {
                char offset = char.IsUpper(letter) ? 'A' : 'a';
                letter = (char)(((letter+shift-offset) % 26) + offset);
            }

            buffer[i] = letter;
        }
        
        return new string(buffer);
    }

    public static string Decode(string messsage, int shift)
    {
        return "fart";
    }
    
}