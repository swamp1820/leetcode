namespace test;

public class UnitTests
{
    [Theory]
    [InlineData("1807", "7810", "1A3B")]
    [InlineData("1123", "0111", "1A1B")]
    [InlineData("1234", "0111", "0A1B")]
    [InlineData("1122", "2211", "0A4B")]
    public void Initial_Tests(string secret, string guess, string expected)
    {
        var solution = new Solution();
        var result = solution.GetHint(secret, guess);
        Assert.Equal(expected, result);
    }
}