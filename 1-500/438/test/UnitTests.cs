namespace test;

public class UnitTests
{
    [Theory]
    [InlineData("cbaebabacd", "abc", new int[]{0,6})]
    [InlineData("abab", "ab", new int[]{0,1,2})]
    public void Initial_Tests(string input, string input2, int[] expected)
    {
        var solution = new Solution();
        var result = solution.FindAnagrams(input, input2);
        Assert.Equal(expected, result);
    }
}