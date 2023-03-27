namespace test;

public class UnitTests
{
    [Theory]
    [InlineData(new[] { "i", "love", "leetcode", "i", "love", "coding" }, 2, new[] { "i", "love" })]
    [InlineData(new[] { "the", "day", "is", "sunny", "the", "the", "the", "sunny", "is", "is" }, 4, new[] { "the", "is", "sunny", "day" })]
    public void Initial_Tests(string[] input, int input2, string[] expected)
    {
        var solution = new Solution();
        var result = solution.TopKFrequent(input, input2);
        Assert.Equal(expected, result);
    }
}