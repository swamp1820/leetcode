namespace test;

public class UnitTests
{
    [Theory]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(4, 3)]
    
    public void Initial_Tests(int input, int expected)
    {
        var solution = new Solution();
        var result = solution.Fib(input);
        Assert.Equal(expected, result);
    }
}
