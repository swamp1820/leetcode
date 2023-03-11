namespace test;

public class UnitTests
{
    [Fact]
    public void Initial_Tests()
    {
        var solution = new Solution();
        var image = new int[][] { new int[] { 1, 1, 1 }, new int[] { 1, 1, 0 }, new int[] { 1, 0, 1 } };
        var expected = new int[][] { new int[] { 2, 2, 2 }, new int[] { 2, 2, 0 }, new int[] { 2, 0, 1 } };
        var result = solution.FloodFill(image, 1, 1, 2);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Initial_Tests2()
    {
        var solution = new Solution();
        var image = new int[][] { new int[] { 0,0,0 }, new int[] { 0,0, 0 }};
        var expected = new int[][] { new int[] { 0,0,0 }, new int[] { 0,0, 0 }};
        var result = solution.FloodFill(image, 0, 0, 0);
        Assert.Equal(expected, result);
    }
}