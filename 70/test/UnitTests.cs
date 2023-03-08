namespace test;

public class UnitTests
{
    [Theory]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    [InlineData(4, 5)]
    [InlineData(5, 8)]
    [InlineData(6, 13)]
    [InlineData(45, 1836311903)]

    public void Initial_Tests(int input, int expected)
    {
        var solution = new Solution();
        var result = solution.ClimbStairs(input);
        Assert.Equal(expected, result);
    }
}
