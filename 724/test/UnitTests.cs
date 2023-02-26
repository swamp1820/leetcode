namespace test;

public class UnitTests
{
    [Theory]
    [InlineData(new int[]{1,7,3,6,5,6}, 3)]
    [InlineData(new int[]{1,2,3}, -1)]
    [InlineData(new int[]{2,1,-1}, 0)]
    [InlineData(new int[]{-1,-1,-1,-1,-1,0}, 2)]
    public void Initial_Tests(int[] input, int expected)
    {
        var solution = new Solution();
        var result = solution.PivotIndexSum(input);
        Assert.Equal(expected, result);
    }
}