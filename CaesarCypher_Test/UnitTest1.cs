namespace CaesarCypher_Test;
using CaesarCypher;
public class UnitTest1
{
    [Theory]
    [InlineData("ij", "hi", 1)]
    [InlineData("werhmi", "sandie", 4)]
    public void Test1(string expectedMessage, string encodedMessage, int shift)
    {
        Assert.Equal(expectedMessage, CaesarCipher.Encode(encodedMessage,shift));
    }
}