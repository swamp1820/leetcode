namespace test;

public class UnitTests
{
    [Theory]
    [InlineData("anagram", "nagaram", true)]
    [InlineData("rat", "car", false)]
    [InlineData("ac", "bb", false)]
    [InlineData("fe", "ja", false)]
    public void Initial_Tests(string input, string input2, bool expected)
    {
        var solution = new Solution();
        var result = solution.IsAnagram(input, input2);
        Assert.Equal(expected, result);
    }
}