namespace test;

public class UnitTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 1 }, true)]
    [InlineData(new[] { 1, 2, 3, 4 }, false)]
    [InlineData(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]

    public void Initial_Tests(int[] input, bool expected)
    {
        var solution = new Solution();
        var result = solution.ContainsDuplicate(input);
        Assert.Equal(expected, result);
    }
}