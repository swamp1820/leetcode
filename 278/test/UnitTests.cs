

namespace test;

public class UnitTests
{
    [Theory]
    [InlineData(5,4)]
    public void Initial_Tests(int input, int expected)
    {
        var solution = new Solution();
        var result = solution.FirstBadVersion(input);
        Assert.Equal(expected, result);
    }
}
