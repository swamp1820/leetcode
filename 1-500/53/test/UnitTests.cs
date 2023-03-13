namespace test;

public class UnitTests
{
    [Theory]
    [InlineData(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
    [InlineData(new[] { 1 }, 1)]
    [InlineData(new[] { 5, 4, -1, 7, 8 }, 23)]

    public void Initial_Tests(int[] input, int expected)
    {
        var solution = new Solution();
        var result = solution.MaxSubArray(input);
        Assert.Equal(expected, result);
    }
}