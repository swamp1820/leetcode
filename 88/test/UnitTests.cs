namespace test;

public class UnitTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 0, 0, 0 }, 3, new[] { 2, 5, 6 }, 3, new[] { 1, 2, 2, 3, 5, 6 })]
    [InlineData(new[] { 1 }, 1, new int[] { }, 0, new[] { 1 })]
    [InlineData(new[] { 0 }, 0, new int[] { 1 }, 1, new[] { 1 })]
    [InlineData(new[] { 4, 0, 0, 0, 0, 0 }, 1, new[] { 1, 2, 3, 5, 6 }, 5, new[] { 1, 2, 3, 4, 5, 6 })]
    public void Initial_Tests(int[] input1, int n, int[] input2, int m, int[] expected)
    {
        var solution = new Solution();
        solution.Merge(input1, n, input2, m);
        Assert.Equal(expected, input1);
    }
}