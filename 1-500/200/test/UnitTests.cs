namespace test;

public class UnitTests
{
    [Fact]
    public void Initial_Tests()
    {
        var solution = new Solution();
        var grid = new char[][] { new char[] {'1','1','1','1','0' },new char[]{'1','1','0','1','0'},new char[]{'1','1','0','0','0'},new char[]{'0','0','0','0','0'} };
        var result = solution.NumIslands(grid);
        Assert.Equal(1, result);
    }

    [Fact]
    public void Initial_Tests2()
    {
        var solution = new Solution();
        var grid = new char[][] { new char[] {'1','1','0','0','0' },new char[]{'1','1','0','0','0'},new char[]{'0','0','1','0','0'},new char[]{'0','0','0','1','1'} };
        var result = solution.NumIslands(grid);
        Assert.Equal(3, result);
    }

    [Fact]
    public void Initial_Tests3()
    {
        var solution = new Solution();
        var grid = new char[][] { new char[] {'1','1','1' },new char[]{'0','1','0'},new char[]{'1','1','1'}};
        var result = solution.NumIslands(grid);
        Assert.Equal(1, result);
    }

       [Fact]
    public void Initial_Tests4()
    {
        var solution = new Solution();
          var grid = new char[][] { new char[] {'1','0','1','1','1' },new char[]{'1','0','1','0','1'},new char[]{'1','1','1','0','1'} };
      
        var result = solution.NumIslands(grid);
        Assert.Equal(1, result);
    }

}