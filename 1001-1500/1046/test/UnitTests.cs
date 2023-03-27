namespace test;

public class UnitTests
{
    [Theory]
    [InlineData(new[] { 2,7,4,1,8,1 }, 1)]
    [InlineData(new[] { 1 }, 1)]
    public void Initial_Tests(int[] input, int expected)
    {
        var solution = new Solution();
        var result = solution.LastStoneWeight(input);
        Assert.Equal(expected, result);
    }
}