namespace test;

public class UnitTests
{
    [Theory]
    [InlineData("abc","ahbgdc", true)]
    [InlineData("axc","ahbgdc", false)]
    [InlineData("","ahbgdc", true)]
    [InlineData("asdasd","", false)]
    public void Initial_Tests(string input1, string input2,bool expected)
    {
        var solution = new Solution();
        var result = solution.IsSubsequence(input1,input2);
        Assert.Equal(expected, result);
    }
}