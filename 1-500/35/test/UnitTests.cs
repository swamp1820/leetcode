namespace test;

public class UnitTests
{
    [Theory]
    [InlineData(new[] { 1, 3, 5, 6 }, 5, 2)]
    [InlineData(new[] { 1, 3, 5, 6 }, 2, 1)]
    [InlineData(new[] { 1, 3, 5, 6 }, 7, 4)]
    [InlineData(new[] { 1, 3, 5, 6 }, 0, 0)]
    public void Initial_Tests(int[] input, int target, int expected)
    {
        var solution = new Solution();
        var result = solution.SearchInsert(input, target);
        Assert.Equal(expected, result);
    }
}