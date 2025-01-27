namespace CaesarCypher_Test;
using CaesarCypher;
public class UnitTest1
{
    [Theory]
    [InlineData("ij", "hi")]
    public void Test1(string expectedMessage, string encodedMethod)
    {
        Assert.Equal(expectedMessage, CaesarCipher.Encode("hi",1));
    }
}