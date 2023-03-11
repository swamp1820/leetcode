namespace test;

public class UnitTests
{
    [Theory]
    [InlineData(new[] { 2, 3, 4, 7, 11 }, 5, 9)]
    [InlineData(new[] { 2, 3, 4, 7, 13 }, 5, 9)]
    [InlineData(new[] { 1, 2, 3, 4 }, 2, 6)]
    [InlineData(new[] { 2 }, 1, 1)]
    [InlineData(new[] { 1,10,21,22,25 }, 12, 14)]
    
    public void Initial_Tests(int[] input, int k, int expected)
    {
        var solution = new Solution();
        var result = solution.FindKthPositive(input, k);
        Assert.Equal(expected, result);
    }
}
