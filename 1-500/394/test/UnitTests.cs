namespace test;

public class UnitTests
{
    [Theory]
    [InlineData("3[a]2[bc]", "aaabcbc")]
    [InlineData("3[a2[c]]", "accaccacc")]
    [InlineData("2[abc]3[cd]ef", "abcabccdcdcdef")]
    public void Initial_Tests(string input, string expected)
    {
        var solution = new Solution();
        var result = solution.DecodeString(input);
        Assert.Equal(expected, result);
    }
}