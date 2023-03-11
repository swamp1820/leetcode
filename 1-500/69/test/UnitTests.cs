namespace test;

public class UnitTests
{
    [Theory]
    [InlineData(4, 2)]
    [InlineData(8, 2)]
    [InlineData(2147395600, 46340)]
    [InlineData(2147483647, 46340)]
    public void Initial_Tests(int input1, int expected)
    {
        var solution = new Solution();
        var result = solution.MySqrt(input1);
        Assert.Equal(expected, result);
    }
}