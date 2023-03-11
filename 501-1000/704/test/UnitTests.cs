namespace test;

public class UnitTests
{
    [Theory]
    [InlineData(new[] { -1, 0, 3, 5, 9, 12 }, 9, 4)]
    [InlineData(new[] { -1, 0, 3, 5, 9, 12 }, 2, -1)]
    [InlineData(new[] { 5 }, 5, 0)]
    [InlineData(new[] { 2, 5 }, 5, 1)]

    public void Initial_Tests(int[] input, int target, int expected)
    {
        var solution = new Solution();
        var result = solution.Search(input, target);
        Assert.Equal(expected, result);
    }
}