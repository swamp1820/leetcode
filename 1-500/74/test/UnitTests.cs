namespace test;

public class UnitTests
{
    [Fact]
    public void Initial_Test()
    {
        var solution = new Solution();
        var result = solution.SearchMatrix(new int[][] { new int[]{1,3,5,7},new int[]{10,11,16,20},new int[] {23,30,34,60} },3);
        Assert.True(result);
    }

     [Fact]
    public void Initial_Test2()
    {
        var solution = new Solution();
        var result = solution.SearchMatrix(new int[][] { new int[]{1,3,5,7},new int[]{10,11,16,20},new int[] {23,30,34,60} },13);
        Assert.False(result);
    }
}