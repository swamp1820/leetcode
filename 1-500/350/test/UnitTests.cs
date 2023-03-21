namespace test;

public class UnitTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 2, 1 }, new int[] { 2, 2 }, new[] { 2, 2 })]
    [InlineData(new[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 }, new[] { 9, 4 })]
    [InlineData(new[] { 1, 2, 2, 1 }, new int[] { 1, 1 }, new[] { 1, 1 })]
    public void Initial_Tests(int[] input, int[] input2, int[] expected)
    {
        var solution = new Solution();
        var result = solution.Intersect(input, input2);
        Assert.Equal(expected, result);
    }
}