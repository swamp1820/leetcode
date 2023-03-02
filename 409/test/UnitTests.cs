namespace test;

public class UnitTests
{
    [Theory]
    [InlineData("abccccdd",7)]
    [InlineData("a",1)]
    public void Initial_Tests(string input, int expected)
    {
        var solution = new Solution();
        var result = solution.LongestPalindrome(input);
        Assert.Equal(expected, result);
    }
}