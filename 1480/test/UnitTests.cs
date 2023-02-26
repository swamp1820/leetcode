namespace test;

public class UnitTests
{
    [Theory]
    [InlineData(new int[]{1,2,3,4}, new int[]{1,3,6,10})]
    [InlineData(new int[]{1,1,1,1,1}, new int[]{1,2,3,4,5})]
    [InlineData(new int[]{3,1,2,10,1}, new int[]{3,4,6,16,17})]
    public void Initial_Tests(int[] input, int[] expected)
    {
        var solution = new Solution();
        var result = solution.RunningSum(input);
        Assert.Equal(expected, result);
    }
}