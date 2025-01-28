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
        Assert.Equal(expectedMessage, CaesarCypher.Encode(encodedMessage,shift));
    }

    [Theory]
    [InlineData("hi", "ij", 1)]

    [InlineData("hello world", "olssv dvysk", 7)]

    public void Test2(string expectedMessage, string encodedMessage, int shift)
    {
        Assert.Equal(expectedMessage, CaesarCypher.Decode(encodedMessage, shift));
    }

    [Theory]
    [InlineData("Hi my name is braeden", "Tu yk zmyq ue ndmqpqz")]
    public void Test3(string expectedMessage, string encodedMessage)
    {
        Assert.Equal(expectedMessage.ToLower(), CaesarCypher.Crack(encodedMessage));
    } 
}