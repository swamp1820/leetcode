namespace test;

public class UnitTests
{
    [Theory]
    [InlineData(new[] { 4, 3, 2, 1 }, new[] { 1, 2, 3, 4 })]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
    [InlineData(new[] { 5, 2, 3, 1 }, new[] { 1, 2, 3, 5 })]
    [InlineData(new[] { -4, 0, 7, 4, 9, -5, -1, 0, -7, -1 }, new[] { -7, -5, -4, -1, -1, 0, 0, 4, 7, 9 })]

    public void Initial_Tests(int[] input, int[] expected)
    {
        var solution = new Solution();
        var result = solution.SortArray(input);
        Assert.Equal(expected, result);
    }
}