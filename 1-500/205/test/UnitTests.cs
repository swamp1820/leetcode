namespace test;

public class UnitTests
{
    [Theory]
    [InlineData("foo","bar", false)]
    [InlineData("egg","add", true)]
    [InlineData("paper","title", true)]
    public void Initial_Tests(string input1, string input2,bool expected)
    {
        var solution = new Solution();
        var result = solution.IsIsomorphic(input1,input2);
        Assert.Equal(expected, result);
    }
}