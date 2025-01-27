namespace CaesarCypher_Test;
using CaesarCypher;
public class UnitTest1
{
    [Theory]
    [InlineData("ij", "hi", 1)]
    [InlineData("werhmi", "sandie", 4)]
    [InlineData("werhmi", "SANDIE", 4)]
    [InlineData(" werhmi ", " SANDIE ", 4)]
    [InlineData("olssv dvysk", "hello world", 7)]

    
    
    public void Test1(string expectedMessage, string encodedMessage, int shift)
    {
        Assert.Equal(expectedMessage, CaesarCipher.Encode(encodedMessage,shift));
    }
}