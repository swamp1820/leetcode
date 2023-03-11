namespace test;

public class UnitTests
{
    [Theory]
    [InlineData(new char[]{'a','a','b','b','c','c','c'}, new char[]{'a','2','b','2','c','3'})]
    [InlineData(new char[]{'a'}, new char[]{'a'})]
    [InlineData(new char[]{'a','b','b','b','b','b','b','b','b','b','b','b','b'}, new char[]{'a','b','1','2'})]
    [InlineData(new char[]{'a','a','a','b','b','a','a'}, new char[]{'a','3','b','2','a','2'})]
    public void Initial_Tests(char[] input, char[] expected)
    {
        var solution = new Solution();
        var result = solution.CharSolution(input);
        Assert.Equal(expected, result);
    }
}