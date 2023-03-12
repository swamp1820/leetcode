namespace test;

public class UnitTests
{
    [Theory]
    [InlineData("ab#c", "ad#c", true)]
    [InlineData("ab##", "cd##", true)]
     [InlineData("a#c", "b", false)]
    public void Initial_Tests(string s, string t, bool expected)
    {
        var solution = new Solution();
        var result = solution.BackspaceCompare(s, t);
        Assert.Equal(expected, result);
    }
}