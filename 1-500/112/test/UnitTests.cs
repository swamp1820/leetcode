
namespace test;

public class UnitTests
{
    [Fact]
    public void Initial_Test1()
    {
        var solution = new Solution();
        var list = new TreeNode(1, new TreeNode(2), new TreeNode(3));
        var result = solution.HasPathSum(list,5);
        Assert.False(result);
    }
     [Fact]
    public void Initial_Test2()
    {
        var solution = new Solution();
        var list = new TreeNode(5, new TreeNode(4, new TreeNode(11, new TreeNode(7), new TreeNode(2)),null), new TreeNode(8, new TreeNode(13), new TreeNode(4, null, new TreeNode(1))));
        var result = solution.HasPathSum(list, 22);
        Assert.True(result);
    }
     [Fact]
    public void Initial_Test3()
    {
        var solution = new Solution();
        var list = new TreeNode(1, new TreeNode(-2, new TreeNode(1, new TreeNode(-1)), new TreeNode(3)), new TreeNode(-3, new TreeNode(-2), null));
        var result = solution.HasPathSum(list, -4);
        Assert.True(result);
    }
}
